using BasicProblems;
using BasicProblems.ExcelImport;
using Newtonsoft.Json;
using Spire.Xls;

public class Program
{
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


        var technologiesObj = new Technology();
        var brandObj = new Brand();

        var technologies = technologiesObj.GetTechnologies();
        var brands = brandObj.GetBrands();

        var combinationsObj = new Technology_Brand();
        var combinations = combinationsObj.GetCombinations();

        //Create a Workbook object
        Workbook workbook = new Workbook();

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
        sheet.Range["A2"].DataValidation.Values = technologies.ToArray();

        //Create a drop-down list in the specified cell
        sheet.Range["A2"].DataValidation.IsSuppressDropDownArrow = false;

        //Set the values of the drop-down list 
        sheet.Range["B2"].DataValidation.Values = brands.ToArray();


        //Create a drop-down list in the specified cell
        sheet.Range["B2"].DataValidation.IsSuppressDropDownArrow = false;

        AddMetadataWorksheet(workbook);

        var startColumn = 7;
        foreach (var item in combinations)
        {
            
            sheet[1, startColumn].Value = item.Key;
            sheet.Columns[startColumn-1].ColumnWidth = 30;
            sheet.Rows[0].Style.Font.IsBold = true;
            int rowNum = 2;
            foreach (var brand in item.Value)
            {
                sheet.SetCellValue(rowNum, startColumn, brand);
                rowNum++;
            }

            startColumn++;
        }


        //Save the result document
        workbook.SaveToFile("ExcelDropdownList.xlsx", ExcelVersion.Version2010);

        #endregion
    }

    private static Worksheet AddMetadataWorksheet(Workbook workbook)
    {
        var workSheet = workbook.Worksheets.Add("Metadata");
        var metadata = new Metadata();
        metadata.Schema = Metadata.CurrentSchema;
        var json = JsonConvert.SerializeObject(metadata);
        workSheet.SetCellValue(1, 1, json);
        workSheet.Protect("products", SheetProtectionType.None);
        return workSheet;
    }
}

public class Metadata
{
    public const string CurrentSchema = "1.0";

    public string Schema { get; set; }
}