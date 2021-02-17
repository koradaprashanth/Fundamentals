using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class MinimumIndexSum
    {
        //list1 = ["Shogun","Tapioca Express","Burger King","KFC"], list2 = ["KNN","KFC","Burger King","Tapioca Express","Shogun"]
        public string[] FindRestaurant(string[] list1, string[] list2)
        {
            Dictionary<int, List<string>> ds = new Dictionary<int, List<string>>();
            for (int i = 0; i < list1.Length; i++)
            {
                for (int j = 0; j < list2.Length; j++)
                {
                    if(list1[i].Equals(list2[i]))
                    {
                        if(!ds.ContainsKey(i+j))
                             ds.Add(i + j, new List<string>());


                        ds[i + j].Add(list1[i]);
                    }
                }
            }

            int min_index_sum = int.MaxValue;
            foreach (var item in ds.Keys)
            {
                min_index_sum = Math.Min(min_index_sum, item);
            }
            String[] res = new String[ds[min_index_sum].Count];
            return  ds[min_index_sum].ToArray();

        }
    }
}
