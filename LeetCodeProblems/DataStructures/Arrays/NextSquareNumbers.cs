using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class NextSquareNumbers
    {
       
        public void NextSquareNumbersMethod()
        {
            int[] squareNumbers = new int[10];
            //Calculate the next square number

            for (int i = 0; i < 10; i++)
            {
                int square= (i + 1) * (i + 1);
                squareNumbers[i] = square;
            }

            foreach(var item in squareNumbers)
            {
                Console.WriteLine(item);
            }
        }

    }
}
