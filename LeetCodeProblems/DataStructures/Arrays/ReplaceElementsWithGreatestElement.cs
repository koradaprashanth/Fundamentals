using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class ReplaceElementsWithGreatestElement
    {
        public void ReplaceElements(int[] arr)
        {
            //17,18,5,4,6,1
            //-1 is last element - replace from the last

            int sofarhighestnumber=arr[arr.Length-1];
            arr[arr.Length - 1] = -1;
            for (int i = arr.Length-2; i >=0;  i--)
            {
                int temp = arr[i];

                arr[i] = sofarhighestnumber;

                if (temp > sofarhighestnumber)
                    sofarhighestnumber = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

    }
}
