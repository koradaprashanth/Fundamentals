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
using System.Text.RegularExpressions;
using Spire.Xls;
using BasicProblems.ExcelImport;
using Spire.Xls.Core;
using SkiaSharp;

namespace coreWebApp.Controllers
{
    public class HomeController : Controller
    {

        public const string SpecialCharacters = "?¿!¡*%#$(){}[]^&/\\~+-`@_=|:;'<>.,";
        private readonly ILogger<HomeController> _logger;

        private readonly IUnitSystem englishUnitSystem;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //string inFilePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\V4\\MudProducts.xlsx";
            //string outFilePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\V3\\rewriteFile.json";
            //var rewritePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\V4\\brand.json";
            //var newId = Guid.NewGuid().ToString("N");
            //UsingOleDb(inFilePath, outFilePath, "Technology");
            //UsingOleDb(inFilePath, outFilePath, "NewStructure");

            //var products = UsingOleDbToGetBrandValues(inFilePath, "NewStructure");
            //GenericRewriteJson(products, rewritePath);

           

            using (var stream = GetExcelTemplate())
            {
                return File(
                    stream.ToArray(),
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    "products-template.xlsm");
            }
        }

        public MemoryStream GetExcelTemplate()
        {
            var technologiesObj = new Technology();
            var brandObj = new Brand();

            var technologies = technologiesObj.GetTechnologies();
            var brands = brandObj.GetBrands();

            var combinationsObj = new Technology_Brand();
            var combinations = combinationsObj.GetCombinations();

            //Create a Workbook object
            Workbook workbook = new Workbook();
            //FileStream fileStream = new FileStream(@"C:\Users\PKorada\Documents\Projects\Fundamentals\BasicProblems\ExcelImport\CustomProductCatalog.xlsm", FileMode.Open);

            //Initailize worksheet
            workbook.LoadFromFile(@"C:\Users\PKorada\Documents\Projects\Fundamentals\BasicProblems\ExcelImport\CustomProductCatalog.xlsm");
            //Get the first worksheet 
            Worksheet sheet = workbook.Worksheets[0];
            var columnIndex = 0;
            sheet[1, 1].Value = "Technology";
            sheet.Columns[columnIndex].ColumnWidth = 20;
            sheet.Columns[columnIndex].Style.Font.IsBold = true;
            var numHeaderRows1 = sheet.LastDataRow;

            var columnIndex1 = 1;
            sheet[1, 2].Value = "Brand";
            sheet.Columns[columnIndex1].ColumnWidth = 20;
            sheet.Columns[columnIndex1].Style.Font.IsBold = true;
            var numHeaderRow2 = sheet.LastDataRow;

            //Set the values of the drop-down list 
            //sheet.Range["A2"].DataValidation.Values = technologies.ToArray();
            sheet.Range["AX1"].Text = "Technologies";
            for (int i = 1; i < technologies.Count; i++)
            {
                sheet.Range["AX" + (i + 1)].Text = technologies[i];
            }


            CellRange rangeName = sheet.Range["A2"];
            rangeName.DataValidation.AllowType = CellDataType.Formula;
            rangeName.DataValidation.DataRange = sheet.Range["AX2:AX" + technologies.Count];
            rangeName.DataValidation.IgnoreBlank = true;
            rangeName.Activate();
            //hide column X                                 
            //sheet.HideColumn(sheet.Range["AX1"].Column);

            //Create a drop-down list in the specified cell
            sheet.Range["A2"].DataValidation.IsSuppressDropDownArrow = false;

            ////Set the values of the drop-down list 
            //sheet.Range["B2"].DataValidation.Values = brands.ToArray();
            sheet.Range["AY1"].Text = "Brands";
            for (int i = 1; i < brands.Count; i++)
            {
                sheet.Range["AY" + (i + 1)].Text = brands[i];
            }

            CellRange rangeNameB = sheet.Range["B2"];
            rangeNameB.DataValidation.AllowType = CellDataType.Formula;
            rangeNameB.DataValidation.DataRange = sheet.Range["AY2:AY" + brands.Count];
            rangeNameB.DataValidation.IgnoreBlank = true;
            rangeNameB.Activate();
            //hide column X                                 
            //sheet.HideColumn(sheet.Range["AY1"].Column);


            ////Create a drop-down list in the specified cell
            sheet.Range["B2"].DataValidation.IsSuppressDropDownArrow = false;

            AddMetadataWorksheet(workbook);
            INamedRange namedRange;
            var startColumn = 10;
            foreach (var item in combinations)
            {
                var columnName = GetExcelLetter(startColumn);
                sheet[1, startColumn].Value = TrimAllInvalidCharacters(item.Key); // TrimAllWhiteSpaces(item.Key).Replace("-","").Replace("&","");
                sheet.Columns[startColumn - 1].ColumnWidth = 30;
                sheet.Rows[0].Style.Font.IsBold = true;
                namedRange = workbook.NameRanges.Add(sheet.Range[columnName + 1].Text);
                int rowNum = 2;
                for (int i = 0; i < item.Value.Count; i++)
                {
                    sheet.SetCellValue(rowNum, startColumn, item.Value[i]);
                    rowNum++;
                }
                namedRange.RefersToRange = sheet.Range[columnName + 2 + ":" + columnName + (rowNum - 1)];

                startColumn++;
            }


            sheet.Range["B2"].DataValidation.Formula1 = GetDependentSelectionFormula("A", 2);//"=INDIRECT($A$2)";//=INDIRECT(SUBSTITUTE(SUBSTITUTE(SUBSTITUTE($A$2,\" \",\"\"),\"-\",\"\"),\"&\",\"\"))";



            ////Add ConditionalFormat
            //XlsConditionalFormats xcfs = sheet.ConditionalFormats.Add();

            ////Define the range
            //xcfs.AddRange(sheet.Range["B2"]);

            ////Add condition
            //IConditionalFormat format = xcfs.AddCondition();
            //format.FormatType = ConditionalFormatType.Formula;

            //format.FirstFormula = "=ISERROR(VLOOKUP(B2,INDEX(data!$J$2:$AL$"+ sheet.LastDataRow + ",,MATCH(A2,data!$A$1:$B$1)),1,0))";

            //format.FontColor = Color.White;



            //Save the result document
            var streamTest = new MemoryStream();
            workbook.SaveToStream(streamTest, FileFormat.Xlsm);
            return streamTest;
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
                                {"Id", x[9]},
                                {"Name", x[8]},
                                {"TechnologyId", x[4]},
                                {"Technology", x[4]},
                                {"BrandId", x[5]},
                                {"Brand", x[5]},
                                {"ShL71Id", x[7]},
                                {"ShL71", x[7]},
                                {"SG", x[10]}
                                    };
                             return data;
                         });

                    var json = JsonConvert.SerializeObject(query);
                    System.IO.File.WriteAllText(outFilePath, JsonPrettify(json));
                }
            }
        }


        private static Dictionary<string,string> UsingOleDbToGetProductKeyValues(string inFilePath, string sheetName)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            var connectionString = $@"
        Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source={inFilePath};
        Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT * FROM [{sheetName}$]";
               
                using (var dr = cmd.ExecuteReader())
                {
                    foreach (DbDataRecord item in dr)
                    {
                        keyValuePairs.Add(item[8].ToString(), item[9].ToString());
                    }
                }
            }

            return keyValuePairs;
        }

        private static Dictionary<string, HashSet<string>> UsingOleDbToGetTechnologyValues(string inFilePath, string sheetName)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            var connectionString = $@"
        Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source={inFilePath};
        Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            Dictionary<string, HashSet<string>> keyValuePairs = new Dictionary<string, HashSet<string>>();
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT * FROM [{sheetName}$]";
                keyValuePairs.Add("Technology", new HashSet<string>());
                using (var dr = cmd.ExecuteReader())
                {
                    foreach (DbDataRecord item in dr)
                    {
                        keyValuePairs["Technology"].Add(item[4].ToString());
                    }
                }
            }

            return keyValuePairs;
        }

        private static Dictionary<string, HashSet<string>> UsingOleDbToGetBrandValues(string inFilePath, string sheetName)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            var connectionString = $@"
        Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source={inFilePath};
        Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            Dictionary<string, HashSet<string>> keyValuePairs = new Dictionary<string, HashSet<string>>();
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT * FROM [{sheetName}$]";
                keyValuePairs.Add("Brand", new HashSet<string>());
                using (var dr = cmd.ExecuteReader())
                {
                    foreach (DbDataRecord item in dr)
                    {
                        keyValuePairs["Brand"].Add(item[5].ToString());
                    }
                }
            }

            return keyValuePairs;
        }


        private static Dictionary<string, HashSet<string>> UsingOleDbToGetTechnologyBrandCombos(string inFilePath, string sheetName)
        {
            //"HDR=Yes;" indicates that the first row contains column names, not data.
            var connectionString = $@"
        Provider=Microsoft.ACE.OLEDB.12.0;
        Data Source={inFilePath};
        Extended Properties=""Excel 12.0 Xml;HDR=YES""";
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            Dictionary<string, HashSet<string>> technologyBrandCombinations = new Dictionary<string, HashSet<string>>();
            using (var conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = $@"SELECT * FROM [{sheetName}$]";

                using (var dr = cmd.ExecuteReader())
                {
                    foreach (DbDataRecord item in dr)
                    {
                        if (technologyBrandCombinations.ContainsKey(item[4].ToString()))
                        {
                            technologyBrandCombinations[item[4].ToString()].Add(item[5].ToString());
                        }
                        else
                        {
                            technologyBrandCombinations.Add(item[4].ToString(), new HashSet<string>() { item[5].ToString() });
                        }
                        keyValuePairs.Add(item[8].ToString(), item[9].ToString());
                    }
                }
            }

            return technologyBrandCombinations;
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

        private static void GenericRewriteJson(Dictionary<string, HashSet<string>> products, string rewritePath)
        {           
            string jsonString = JsonConvert.SerializeObject(products);

            System.IO.File.WriteAllText(rewritePath, JsonPrettify(jsonString));
        }

        private static void RewriteJson(Dictionary<string,string> products)
        {
            var path = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\V3\\Recipes\\mud-recipes-v2.json";
            var rewritePath = "C:\\Users\\PKorada\\Documents\\Projects\\Fundamentals\\coreWebApp\\Files\\V3\\Recipes\\rewriteFile.json";

            string jsonString = System.IO.File.ReadAllText(path);


            var jsonParsed = JArray.Parse(jsonString);

            foreach (var item in jsonParsed)
            {
                foreach (var recipe in item["Recipes"])
                {
                    foreach (var product in recipe["Products"])
                    {
                        string val;
                        products.TryGetValue(product[0].Value<string>().Trim(), out val);

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

        private static void DeletePropertyJson(string path,string rewritePath)
        {
            string jsonString = System.IO.File.ReadAllText(path);

            var jsonParsed = JArray.Parse(jsonString);

            foreach (var item in jsonParsed)
            {
                foreach (var property in item.Children<JProperty>().ToArray())
                {
                    if (property.Name.Equals("BaseFluids") && property.Value.Type == JTokenType.Array)
                        property.Remove();
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




        private static string GetExcelLetter(int columnNum)
        {
            int num = columnNum;
            int mod = 0;
            string result = String.Empty;
            while (num > 0)
            {
                mod = (num - 1) % 26;
                result = (char)(65 + mod) + result;
                num = (int)((num - mod) / 26);
            }
            return result;
        }

        public static string TrimAllWhiteSpaces(string s)
        {
            return s == null ? null : Regex.Replace(s, @"\s", string.Empty);
        }

        private static string GetDependentSelectionFormula(string columnName, int rowNum)
        {
            var formulaPrefix = "=INDIRECT(";
            var formulaLogic = "$" + columnName + "$" + rowNum;
            var substitudeSpaces = "SUBSTITUTE(" + formulaLogic + ",\" \",\"\")";
            var strPrefix = string.Empty;
            var strPostfix = string.Empty;
            foreach (var item in SpecialCharacters)
            {
                strPrefix = strPrefix + "SUBSTITUTE(";
                strPostfix = strPostfix + ",\"" + item + "\",\"\")";
            }
            //CHAR(34)
            strPrefix = strPrefix + "SUBSTITUTE(";
            strPostfix = strPostfix + ",CHAR(34),\"\")";

            return formulaPrefix + strPrefix + substitudeSpaces + strPostfix + ")";

            // var formula = "=INDIRECT(SUBSTITUTE(SUBSTITUTE(SUBSTITUTE(,\" \",\"\"),\"-\",\"\"),\"&\",\"\"))";
        }

        public static string TrimAllInvalidCharacters(string s)
        {
            s = s.Replace(" ", string.Empty);
            foreach (var item in SpecialCharacters)
            {
                s = s.Replace(item.ToString(), string.Empty);
            }

            return s;
        }


        private static Worksheet AddMetadataWorksheet(Workbook workbook)
        {
            var workSheet = workbook.Worksheets.Add("Metadata");
            var metadata = new Metadata();
            metadata.Schema = Metadata.CurrentSchema;
            var json = JsonConvert.SerializeObject(metadata);
            workSheet.SetCellValue(1, 1, json);
            //workSheet.Protect("products", SheetProtectionType.None);
            return workSheet;
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


public class Metadata
{
    public const string CurrentSchema = "1.0";

    public string Schema { get; set; }
}