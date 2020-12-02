using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Company.FB
{
    public class LeftRotation
    {
        public void rotLeft(int[] a, int d)
        {

            //1, 2, 3, 4, 5 
            //2
            //2,3,4,5,1   3,4,5,1,2   4,5,1,2,3
            int[] result = new int[a.Length];
            int shift = a.Length - d;
            for (int i = 0; i < a.Length; i++)
            {
                result[(i + shift) % a.Length] = a[i];
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();
        }
    }
}
