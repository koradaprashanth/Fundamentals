using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class Factorial
    {
        public int getFactorial(int number)
        {
            int product=1;
            for (int i = number; i > 0; i--)
            {
                product = product * i; 
            }

            return product;
        }

        public int getFactorialRecursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * getFactorialRecursion(number - 1);
        }
    }
}
