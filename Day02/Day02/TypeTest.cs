using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class TypeTest
    {
        static void Main(string[] args)
        {
            char ch1 = (char)65;
            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);

            int su1 = 10;
            Console.WriteLine(su1);

            int su2 = 0x10;
            Console.WriteLine(su2);

            int su3 = 0b10;
            Console.WriteLine(su3);

            double d1 = 3.14;
            int pi = (int)d1;
            Console.WriteLine(pi);
        }
    }
}
