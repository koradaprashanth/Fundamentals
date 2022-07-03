using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class Palindrome
    {
        public int getPalindrome(int number)
        {
            int reminder;
            int sum = 0;
            int temp = number;
            while (number > 0)
            {
                reminder = number % 10;

                sum = (sum * 10) + reminder;

                number = number / 10;
            }

            return number;
        }
    }

}
