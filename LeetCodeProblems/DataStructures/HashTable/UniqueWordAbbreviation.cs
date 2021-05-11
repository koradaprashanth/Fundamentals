using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class UniqueWordAbbreviation
    {
        Dictionary<string, HashSet<string>> dc = new Dictionary<string, HashSet<string>>();
        public UniqueWordAbbreviation(string[] dictionary)
        {
            
            foreach (var item in dictionary)
            {
                string abr= getAbbrev(item);
                if (!dc.ContainsKey(abr))
                {
                    dc.Add(abr, new HashSet<string>());
                }

                dc[abr].Add(item);


            }
        }

        public bool IsUnique(string word)
        {
            string wordAbr = getAbbrev(word);
            if (dc.ContainsKey(wordAbr))
            {
                if(dc[wordAbr].Contains(word) && dc[wordAbr].Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }

            return true;
           




        }

        public string getAbbrev(string word)
        {
            if (word.Length <= 2) return word;

            return String.Concat(word[0] , word.Length - 2 , word[word.Length - 1]);
        }
    }
}
