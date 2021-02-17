using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.DataStructures.HashTable
{
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            //19
            HashSet<int> seen = new HashSet<int>();
            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = getNumber(n);
            }

            return n == 1;
            
        }

        int getNumber(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int d = n % 10;
                n = n / 10;
                sum = sum + (d * d);

            }

            return sum;
        }
    }
}
