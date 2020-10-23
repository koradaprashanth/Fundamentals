using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class SquaresOfSortedArray
    {
        public void SortedSquares(int[] A)
        {

            #region SimpleWayWithSortFunction

            //for (int i = 0; i < A.Length; i++)
            //{
            //    A[i]=A[i] * A[i];
            //}

            //Array.Sort(A);

            #endregion

            #region WithoutSortFunction
            //if (A == null) return null;

            int[] ans = new int[A.Length];

            int start = 0, end = A.Length - 1;
            int i = end; // insert position.
            while (start <= end)
            { // <  or <=  ?   be careful about ==
                int pow1 = A[start] * A[start];
                int pow2 = A[end] * A[end];
                if (pow1 > pow2)
                {
                    ans[i--] = pow1;
                    start++;
                }
                else
                {
                    ans[i--] = pow2;
                    end--;
                }
            }
            #endregion


            for (int y = 0; y < ans.Length; y++)
            {
                Console.WriteLine(ans[y]);
            }


            Console.ReadLine();
        }
    }


}
