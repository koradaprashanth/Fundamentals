using BasicProblems;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a Number To Check Palindrome : ");
        int number = int.Parse(Console.ReadLine());

        Palindrome p = new Palindrome();
        Console.WriteLine(p.getPalindrome(number));
        
    }
}