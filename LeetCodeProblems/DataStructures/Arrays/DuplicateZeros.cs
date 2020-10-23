using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.Arrays
{
    public class DuplicateZeros
    {
        public void DuplicateZerosMethod(int[] arr)
        {
            //{ 1, 0, 2, 3, 0, 4, 5, 0 }
            int possibledubs = 0;
            int length_ = arr.Length - 1; 
            for (int i = 0; i <= length_-possibledubs; i++)
            {
               
                if (arr[i] == 0)
                {
                    if (i == length_ - possibledubs)
                    {
                        arr[length_] = 0;
                        length_ = length_ - 1;
                        break;
                    }
                    possibledubs++;
                }
            }


            int last = length_ - possibledubs;
            for (int i = last; i >= 0; i--)
            {

                if (arr[i] == 0)
                {
                    arr[i + possibledubs] = 0;
                    possibledubs --;
                    arr[i + possibledubs] = 0;

                }
                else
                {
                    arr[i + possibledubs] = arr[i];
                }

            }

            for (int a = 0; a < arr.Length; a++)
            {
                Console.WriteLine(arr[a]);
            }

            Console.ReadLine();
        }

    }
}
