using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class CheckIfNAndItsDoubleExists
    {
        public void CheckIfNAndItsDoubleExistsMethod(int[] arr)
        {
            //[3,1,7,11]
            bool flag = false;
            HashSet<int> hast = new HashSet<int>();
            for (int i=0;i<arr.Length;i++)
            {
                if (hast.Contains(arr[i] * 2))
                {
                    flag = true; 
                }
                if (arr[i]%2==0 && hast.Contains(arr[i] / 2))
                {
                    flag = true;
                }

                hast.Add(arr[i]);

            }

            Console.WriteLine(flag);
            Console.ReadLine();            
        }
    }
}
