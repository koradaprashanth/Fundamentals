using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using coreWebApp.Models;
using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.IO;
using System.Data.OleDb;
using OfficeOpenXml;
using System.Drawing;
using OfficeOpenXml.FormulaParsing.LexicalAnalysis;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;
using Slb.Drilling.OceanUnits;
using System.Data.Common;
using static System.Net.WebRequestMethods;
using System.Reflection.Metadata;

namespace coreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitSystem englishUnitSystem;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string inFilePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\Technology.xlsx";
            string outFilePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\technology.json";

            var newId = Guid.NewGuid().ToString("N");
            //UsingOleDb(inFilePath, outFilePath, "Technology");

            return View();
        }

        public static string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static void ConvertExcelToJson(string field, string sourcePath, string desinationPath)
        {

        }

        private static void UsingOleDb(string inFilePath, string outFilePath, string sheetName)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            var connectionString = $@"
        Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source={inFilePath};
        Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT * FROM [{sheetName}$]";
                using (var dr = cmd.ExecuteReader())
                {
                    var query =
                        (from DbDataRecord row in dr
                         select row).Select(x =>
                         {
                             var data = new Dictionary<string, object>
                                    {
                                {dr.GetName(0), x[0]},
                                {dr.GetName(1), x[1]},
                                {dr.GetName(2), x[2]},
                                {dr.GetName(3), x[3]}
                                    };
                             return data;
                         });

                    var json = JsonConvert.SerializeObject(query);
                    System.IO.File.WriteAllText(outFilePath, json);
                }
            }
        }

        private static void GetLegacyExcelDataIntoDictionary()
        {
            var path = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\Mud_Recipes.xlsx";
            var fi = new FileInfo(path);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
       

            Dictionary<string, string> recipes = new Dictionary<string, string>();
            MudRecipes recipe = new MudRecipes();
            using (var package = new ExcelPackage(fi))
            {
                var workbook = package.Workbook;
                var worksheet = workbook.Worksheets.First();
                int colCount = worksheet.Dimension.End.Column;  //get Column Count
                int rowCount = worksheet.Dimension.End.Row;

                for (int row = 2; row <= rowCount; row++)
                {
                    for (int col = 1; col <= colCount; col++)
                    {
                        if (col == 2)
                        {
                            recipe.Code = worksheet.Cells[row, col].Value?.ToString().Trim();
                        }


                        if (col == 4 && !String.IsNullOrEmpty(recipe.Code) && recipe.Code.StartsWith('M'))
                        {
                            recipe.Name = worksheet.Cells[row, col].Value?.ToString().Trim();
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!String.IsNullOrEmpty(recipe.Code) && !String.IsNullOrEmpty(recipe.Name) && recipe.Code.StartsWith('M'))
                    {
                        if (!recipes.ContainsKey(recipe.Code))
                        {
                            recipes.Add(recipe.Code, recipe.Name);
                        }

                    }

                }
            }
            RewriteJson(recipes);
        }

        
        private static void RewriteJson(Dictionary<string,string> recipes)
        {
            var path = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\mud-recipes-v2.json";
            var rewritePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\rewriteFile.json";

            string jsonString = System.IO.File.ReadAllText(path);


            var jsonParsed = JArray.Parse(jsonString);

            foreach (var item in jsonParsed)
            {
                foreach (var recipe in item["Recipes"])
                {
                    foreach (var product in recipe["Products"])
                    {
                        string val = "";
                        if (product[0].Value<string>().StartsWith("M"))
                        {
                           recipes.TryGetValue(product[0].Value<string>(), out val);
                        }

                        if (!String.IsNullOrEmpty(val))
                        {
                            product[0] = val;
                        }
                    }
                }
            }

            var json = jsonParsed.ToString();

            System.IO.File.WriteAllText(rewritePath, JsonPrettify(json));
        }


        public FluidSystemRecipes Convert(JToken jsonToken)
        {
            var recipes = jsonToken.ToObject<FluidSystemRecipes>();
            recipes.Recipes.ForEach(r => r.Products = r.RawProducts.Select(ConvertFromRawProduct).ToList());
            englishUnitSystem.ConvertDtoToStorage(recipes);

            return recipes;
        }

        private static RecipeProduct ConvertFromRawProduct(List<object> rawProducts)
        {
            return new RecipeProduct()
            {
                Code = rawProducts[0].ToString(),
                Concentration = rawProducts[1] != null ? double.Parse(rawProducts[1].ToString()) : (double?)null,
            };
        }

        private static string SelectKey(JToken component)
        {
            return $"{component["FluidSystem"]}";
        }

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            var csvData = new DataTable("Table");
            try
            {
                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[]
                    {
                        ","
                    });

                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == string.Empty)
                            {
                                fieldData[i] = string.Empty; //fieldData[i] = null
                            }
                            //Skip rows that have any csv header information or blank rows in them
                            if (fieldData[0].Contains("Disclaimer") || string.IsNullOrEmpty(fieldData[0]))
                            {
                                continue;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return csvData;
        }


    }

    public class MudRecipes
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class FluidSystemRecipes
    {
        public string FluidSystem { get; set; }
        public List<string> BaseFluids { get; set; }

        public List<RecipeStorageModel> Recipes { get; set; }
    }

    public class RecipeStorageModel
    {
        public double Density { get; set; }

        [JsonProperty("Products")]
        public List<List<object>> RawProducts { get; set; }

        [JsonIgnore]
        public List<RecipeProduct> Products { get; set; }

        public RecipeStorageModel Clone()
        {
            return new RecipeStorageModel()
            {
                Density = this.Density,
                Products = this.Products.Select(p => new RecipeProduct(p.Code, p.Concentration)).ToList(),
            };
        }
    }

    [DebuggerDisplay("{Code}, {Concentration}")]
    public class RecipeProduct
    {
        public RecipeProduct()
        {
        }

        public RecipeProduct(string code, double? concentration)
        {
            Code = code;
            Concentration = concentration;
        }

        public string Code { get; set; }

        public double? Concentration { get; set; }
    }

    public static class JsonFromResourceProvider
    {
        public static string GetJson(string embeddedResourceFullName, Assembly assembly = null)
        {
            assembly = assembly ?? Assembly.GetCallingAssembly();
            var stream = assembly.GetManifestResourceStream(embeddedResourceFullName);
            return StreamToString(stream);
        }

        private static string StreamToString(Stream stream)
        {
            stream.Position = 0;
            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return reader.ReadToEnd();
            }
        }
    }

}
