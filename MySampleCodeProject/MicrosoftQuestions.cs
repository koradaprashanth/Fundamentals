using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MySampleCodeProject
{
    public static class MicrosoftQuestions
    {

        public static int NumberOfOccurences(int X, int Y, int[] A)
        {
            //(7, 42, [6, 42, 11, 7, 1, 42])
            int N = A.Length;
            int result = -1;
            int nX = 0;
            int nY = 0;
            for (int i = 0; i < N; i++)
            {
                if (A[i] == X)
                    nX += 1;
                else if (A[i] == Y)
                    nY += 1;
                if (nX == nY)
                    result = i;
            }
            if (nX == 0 && nY == 0)
                return -1;
            return result;
        }


        public static int Codility(string[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            //Sorting string array based on length;
            //Considering max length string and checking if it has all letter unique

            A.ToList().Sort((x, y) => y.Length - x.Length);

            Dictionary<char, int> characterInputAddress = new Dictionary<char, int>();

            for (int i = 0; i < A.Length; i++)
            {
                String curr = A[i];
                //if current string length is not equal to unique word length
                if (curr.Length != FindUniqueWordLength(curr)) continue;
                bool charaterExists = false;
                for (int j = 0; j < curr.Length; j++)
                {
                    if (characterInputAddress.ContainsKey(curr[j]))
                    {
                        charaterExists = true;
                        break;
                    }
                }
                //if character does not exists adding character to dictionary 
                if (!charaterExists)
                {
                    for (int j = 0; j < curr.Length; j++)
                    {
                        characterInputAddress.Add(curr[j], i);
                    }
                }
            }
            return characterInputAddress.Count;
        }
        //Helper function for finding unique word length
        public static int FindUniqueWordLength(String s)
        {
            HashSet<char> currWithoutDuplicates = new HashSet<char>();
            for (int i = 0; i < s.Length; i++)
            {
                currWithoutDuplicates.Add(s[i]);
            }
            return currWithoutDuplicates.Count;
        }

        //Time Complexity : O(NlogN) 
        //Space Complexity : O(mn) where m is length of max unique string and n is length of an array.


        public static int Replace3rdOccurance(string S)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int count = 0;
            //Iterating over string.
            for (int i = 0; i < S.Length; i++)
            {
                int repeatLen = 1;
                //Checking for the repeated characters count.
                for (; i + 1 < S.Length && S[i] == S[i + 1]; i++)
                {
                    repeatLen++;
                }
                //Since for every 3rd occurance,we are increasing
                //the count.
                count = count + repeatLen / 3;
            }
            return count;

            //    //Time Complexity : O(n) since we are iterating complete string
            //    //Space Complexity : O(1) since we are not using any additional spaces.
        }
    }


}
   
