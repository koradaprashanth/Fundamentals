using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class HeightChecker
    {
        public void HeightCheckerMethod(int[] heights)
        {
            int[] numHeights = new int[heights.Length];
            Array.Copy(heights, 0, numHeights, 0, heights.Length);
            Array.Sort(numHeights);
            int counter = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i] != numHeights[i])
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            Console.ReadLine();


        }

    }
}
