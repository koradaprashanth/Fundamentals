using BasicProblems;
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

        //Create a Workbook object
        Workbook workbook = new Workbook();

        //Get the first worksheet 
        Worksheet sheet = workbook.Worksheets[0];

        var columnIndex = 3-1;
        sheet[1, 3].Value = "Continent";
        sheet.Columns[columnIndex].ColumnWidth = 20;
        sheet.Columns[columnIndex].Style.Font.IsBold = true;
        var numHeaderRows1 = sheet.LastDataRow;

        var columnIndex1 = 4-1;
        sheet[1, 4].Value = "Country";
        sheet.Columns[columnIndex1].ColumnWidth = 20;
        sheet.Columns[columnIndex1].Style.Font.IsBold = true;
        var numHeaderRow2 = sheet.LastDataRow;

        //Set the values of the drop-down list 
        sheet.Range["C2"].DataValidation.Values = new string[] { "Asia", "North America", "Europe", "South America" };


        var selectionCellRange = sheet[1, 1, numHeaderRows1, 1];
        sheet.Range["C2:C5"].DataValidation.DataRange = selectionCellRange;


        //Create a drop-down list in the specified cell
        sheet.Range["C2"].DataValidation.IsSuppressDropDownArrow = false;

        //Set the values of the drop-down list 
        sheet.Range["D2"].DataValidation.Values = new string[] { "USA", "Canada", "Mexico", "India", "China", "Russia", "Italy", "Germany", "France", "Norway", "Columbia", "Brazil","Peru"};


        //Create a drop-down list in the specified cell
        sheet.Range["D2"].DataValidation.IsSuppressDropDownArrow = false;

        //Save the result document
        workbook.SaveToFile("ExcelDropdownList.xlsx", ExcelVersion.Version2010);

        #endregion
    }
}