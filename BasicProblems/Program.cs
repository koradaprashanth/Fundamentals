using Aspose=Aspose.Cells;
using BasicProblems;
using BasicProblems.ExcelImport;
using Newtonsoft.Json;
using Spire.Xls;
using Spire.Xls.Core;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.Runtime.Intrinsics.Arm;
using static System.Net.Mime.MediaTypeNames;
using System.Reflection;
using Spire.Xls.Core.Spreadsheet.Collections;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Runtime.Intrinsics.X86;

public class Program
{
    public const string SpecialCharacters = "?¿!¡*%#$(){}[]^&/\\~+-`@_=|:;'<>.,";
    public static void Main(string[] args)
    {
        #region Palindrome

        //Console.Write("Enter a Number To Check Palindrome : ");
        //int number = int.Parse(Console.ReadLine());

        //Palindrome p = new Palindrome();
        //Console.WriteLine(p.getPalindrome(number) == number ? true : false);

        #endregion

        #region Fibnocci

        //Console.Write("Enter a Number To Check Fibonacci : ");
        //int number = int.Parse(Console.ReadLine());

        //FibonacciSeries p = new FibonacciSeries();
        //p.getFibonacci(number);

        //Console.ReadLine();

        #endregion

        #region Factorial

        //Console.Write("Please provide factorial number: ");
        //int number = int.Parse(Console.ReadLine());

        //Factorial f = new Factorial();
        //Console.WriteLine(f.getFactorialRecursion(number));


        #endregion

        #region SumOfDigits

        //SumOfDigits sm = new SumOfDigits();
        //Console.Write("Please provide number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(sm.getSumOfDigits(number));

        #endregion

        #region SwappingNumber

        //SwappingNumber sn = new SwappingNumber();
        //sn.Swap(2, 3);

        #endregion

        #region ReverseNumber

        //ReverseNumber rn = new ReverseNumber();
        //Console.Write("Please provide number: ");
        //int number = int.Parse(Console.ReadLine());
        //Console.WriteLine(rn.getReverseNumber(number));        

        #endregion

        #region SpireXls


        //var technologiesObj = new Technology();
        //var brandObj = new Brand();

        //var technologies = technologiesObj.GetTechnologies();
        //var brands = brandObj.GetBrands();

        //var combinationsObj = new Technology_Brand();
        //var combinations = combinationsObj.GetCombinations();

        ////Create a Workbook object
        //Workbook workbook = new Workbook();


        //FileStream fileStream = File.OpenRead("..\\..\\..\\ExcelImport\\CustomProductCatalog.xlsm");
        //fileStream.Seek(0, SeekOrigin.Begin);
        //workbook.LoadFromStream(fileStream);
        ////Initailize worksheet
        ////workbook.LoadFromFile("CustomProductCatalog.xlsm");
        ////Get the first worksheet 
        //Worksheet sheet = workbook.Worksheets[0];
        //var columnIndex = 0;
        //sheet[1, 1].Value = "Technology";
        //sheet.Columns[columnIndex].ColumnWidth = 20;
        //sheet.Columns[columnIndex].Style.Font.IsBold = true;
        //var numHeaderRows1 = sheet.LastDataRow;

        //var columnIndex1 = 1;
        //sheet[1, 2].Value = "Brand";
        //sheet.Columns[columnIndex1].ColumnWidth = 20;
        //sheet.Columns[columnIndex1].Style.Font.IsBold = true;
        //var numHeaderRow2 = sheet.LastDataRow;

        ////Set the values of the drop-down list 
        ////sheet.Range["A2"].DataValidation.Values = technologies.ToArray();
        //sheet.Range["AX1"].Text = "Technologies";
        //for (int i = 1; i < technologies.Count ; i++)
        //{
        //    sheet.Range["AX" + (i+1)].Text = technologies[i];
        //}


        //CellRange rangeName = sheet.Range["A2"];
        //rangeName.DataValidation.AllowType = CellDataType.Formula;
        //rangeName.DataValidation.DataRange = sheet.Range["AX2:AX" + technologies.Count];
        //rangeName.DataValidation.IgnoreBlank = true;
        //rangeName.Activate();
        ////hide column X                                 
        ////sheet.HideColumn(sheet.Range["AX1"].Column);

        ////Create a drop-down list in the specified cell
        //sheet.Range["A2"].DataValidation.IsSuppressDropDownArrow = false;

        //////Set the values of the drop-down list 
        ////sheet.Range["B2"].DataValidation.Values = brands.ToArray();
        //sheet.Range["AY1"].Text = "Brands";
        //for (int i = 1; i < brands.Count; i++)
        //{
        //    sheet.Range["AY" + (i + 1)].Text = brands[i];
        //}

        //CellRange rangeNameB = sheet.Range["B2"];
        //rangeNameB.DataValidation.AllowType = CellDataType.Formula;
        //rangeNameB.DataValidation.DataRange = sheet.Range["AY2:AY" + brands.Count];
        //rangeNameB.DataValidation.IgnoreBlank = true;
        //rangeNameB.Activate();
        ////hide column X                                 
        ////sheet.HideColumn(sheet.Range["AY1"].Column);


        //////Create a drop-down list in the specified cell
        //sheet.Range["B2"].DataValidation.IsSuppressDropDownArrow = false;

        //AddMetadataWorksheet(workbook);
        //INamedRange namedRange;
        //var startColumn = 10;
        //foreach (var item in combinations)
        //{
        //    var columnName = GetExcelLetter(startColumn);
        //    sheet[1, startColumn].Value = TrimAllInvalidCharacters(item.Key); // TrimAllWhiteSpaces(item.Key).Replace("-","").Replace("&","");
        //    sheet.Columns[startColumn - 1].ColumnWidth = 30;
        //    sheet.Rows[0].Style.Font.IsBold = true;
        //    namedRange = workbook.NameRanges.Add(sheet.Range[columnName + 1].Text);
        //    int rowNum = 2;
        //    for (int i = 0; i < item.Value.Count; i++)
        //    {
        //        sheet.SetCellValue(rowNum, startColumn, item.Value[i]);
        //        rowNum++;
        //    }
        //    namedRange.RefersToRange = sheet.Range[columnName + 2 + ":" + columnName + (rowNum-1)];

        //    startColumn++;
        //}


        //sheet.Range["B2"].DataValidation.Formula1 = GetDependentSelectionFormula("A", 2);//"=INDIRECT($A$2)";//=INDIRECT(SUBSTITUTE(SUBSTITUTE(SUBSTITUTE($A$2,\" \",\"\"),\"-\",\"\"),\"&\",\"\"))";



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
        //workbook.SaveToFile("CustomProductCatalog.xls", ExcelVersion.Version2010);

        #endregion


        var dict = new Dictionary<string, List<string>>();

        dict.Add("Test1", new List<string>() { "1"});
        dict.Add("Test2", new List<string>() { "1", "2"});

        Console.WriteLine(dict.Values.Select(x=> x.Count).Max());
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

public class Metadata
{
    public const string CurrentSchema = "1.0";

    public string Schema { get; set; }
}