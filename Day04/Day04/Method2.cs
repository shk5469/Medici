using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Method2
    {
        static void Main(string[] args)
        {
            MyCalc(1, 2, 3, 4, 5);
        }

        static (int, int) MyCalc(params int[] n)
        {
            (int, int) sum = (n.Sum(), n.Max());

            Console.WriteLine(sum);
            return sum;
        }
    }
}
