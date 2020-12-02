using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class SortArrayByParity
    {
        public void SortArrayByParityMethod(int[] A)
        {
            int pointer = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 == 0)
                {
                    int temp = A[i];
                    A[i] = A[pointer];
                    A[pointer] = temp;
                    pointer++;
                }
            }

            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
            Console.ReadLine();
        }
    }
}
