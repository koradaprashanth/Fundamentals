using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class SumOfDigits
    {
        public int getSumOfDigits(int number)
        {
            int reminder, sum =0;

            while (number !=0)
            {
                reminder = number % 10;
                number = number / 10;
                sum = sum + reminder;
            }

            return sum;
        }
    }
}
