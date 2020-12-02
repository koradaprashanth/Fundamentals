using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Company.FB
{
    public class ABigSum
    {

        // Complete the aVeryBigSum function below.
        public void aVeryBigSum(long[] ar)
        {

            //1000000001 1000000002 1000000003 1000000004 1000000005
            long sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum = sum + ar[i];

            }

            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
