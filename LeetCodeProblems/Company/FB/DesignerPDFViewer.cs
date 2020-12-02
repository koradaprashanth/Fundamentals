using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Company.FB
{
    public class DesignerPDFViewer
    {
        public void designerPdfViewer(int[] h, string word)
        {
            //1 3 1 3 1 4 1 3 2 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5 5
            //abc


            //6, 5, 7, 3, 6, 7, 3, 4, 4, 2, 3, 7, 1, 3, 7, 4, 6, 1, 2, 4, 3, 3, 1, 1, 3, 5
            //zbkkfhwplj
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int k = 0;
            for (char ch='a'; ch <= 'z'; ch++)
            {
                dict[ch] = h[k];
                k++;
            }


            int max = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (dict[word[i]] > max)
                {
                    max = dict[word[i]];
                }
            }
            //Console.WriteLine(max);
            Console.WriteLine(max*word.Length);
            Console.ReadLine();

        }
    }
}
