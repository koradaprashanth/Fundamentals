using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class TopKFreq
    {
        //nums = [1,1,1,2,2,3], k = 2
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dc = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dc.ContainsKey(nums[i]))
                {
                    dc[nums[i]] += 1;
                }
                else
                {
                    dc.Add(nums[i], 1);
                }              

            }

            return dc.OrderByDescending(x => x.Value).Select(y => y.Key).Take(k).ToArray();

        }
    }


    public   class cars
    {
        public  void displayBrand()
        {
            Console.WriteLine("dasd");
        }
        
    }

    public class Maruti : cars
    {
        public new void displayBrand()
        {
            Console.WriteLine("Derived Class - I am Maruti");
        }
    }
}
