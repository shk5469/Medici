using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByOut
    {
        static void Main(string[] args)
        {
            int tot, min, max;

            MyCalc(new int[] { 80, 58, 78, 93 }, out tot, out min, out max);
            Console.WriteLine($"{tot}, {min}, {max}");
        }
        static void MyCalc(int[] n, out int tot, out int min, out int max)
        {
            if(n == null || n.Length < 1)
            {
                tot = min = max = 0;
                return;
            }
            tot = n.Sum();
            min = n.Min();
            max = n.Max();

        }
    }
}
