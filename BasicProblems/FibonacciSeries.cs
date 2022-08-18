using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    public class FibonacciSeries
    {
        public void getFibonacci(int number)
        {
            int t1 = 0, t2 = 1,nextterm;
            for (int i = 1; i <= number; i++)
            {
                Console.Write(" " + t1);
                nextterm = t1 + t2;
                t1 = t2;               
                t2 = nextterm;
            }
        }
    }
}
