using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class ConverTest
    {
        static void Main(string[] args)
        {
            int k = 10;
            long lg = k;
            short s = Convert.ToInt16(k);
            k = Int32.MaxValue;
            s = (short)k;
            Console.WriteLine(s);
        }
    }
}
