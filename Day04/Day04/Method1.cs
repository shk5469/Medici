using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Method1
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MySum(0, 100, 2));
            Console.WriteLine(MySum(10, 20, 2));
        }

        static int MySum(int n, int m)
        {
            return n + m;
        }
        static int MySum(params int[] a) //MySum(1,2,3,4,5);
        {
            return a.Sum();
        }

        static int MySum(int start, int end, int n)
        {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % n == 0)
                    sum += i;
            }

            return sum;
        }
    }
}
