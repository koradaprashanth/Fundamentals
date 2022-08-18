using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class ReverseNumber
    {
        public int getReverseNumber(int number)
        {
            //1234
            int reminder;
            int sum = 0;
            while (number > 0)
            {
                reminder = number % 10;

                sum = (sum * 10) + reminder;

                number = number / 10;
            }

            return sum;
        }

    }
}
