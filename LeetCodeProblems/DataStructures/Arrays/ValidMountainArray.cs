using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class ValidMountainArray
    {
        public bool ValidMountainArrayMethod(int[] A)
        {
            // 0, 3, 2, 1 
            int Len = A.Length;
            int i = 0;
            // walk up
            while (i + 1 < Len && A[i] < A[i + 1])
                i++;

            //peak cant be first or last
            if (i == 0 || i == Len - 1)
                return false;

            //walk down
            while (i + 1 < Len && A[i] > A[i + 1])
                i++;

            return i == Len - 1;


            //if (A.Length < 3) return false;
            //if (A[1] < A[0]) return false;

            //bool top = false;
            //for (int i = 0; i < A.Length - 1; i++)
            //{
            //    if (A[i + 1] == A[i]) return false;
            //    if (!top && A[i + 1] < A[i]) top = true;
            //    else if (top && A[i + 1] > A[i]) return false;
            //}
            //return top;

        }
    }
}
