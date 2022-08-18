using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblems
{
    internal class SwappingNumber
    {
        public void Swap(int a,int b)
        {
            //a= 2 , b =3;
            //b= a+b;
            //a= b-a;
            //b= b-a;
            b = a + b;
            a = b - a;
            b = b - a;

            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
        }
    }
}
