using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByValue
    {
        static void Main(string[] args)
        {
            int x, y;
            int n;

            if(int.TryParse(Console.ReadLine(),out n))
                Console.WriteLine(n);

            Swap(out x, out y);
            Console.WriteLine("x={0}, y={1}", x, y);
        }
        static void Swap(int x, int y)
        {
            int tmp = x;
            x = y;
            y = tmp;
        }
        //static void Swap(ref int x, ref int y)
        //{
        //    int tmp = x;
        //    x = y;
        //    y = tmp;
        //}
        static void Swap(out int x, out int y)
        {
            x = 5;
            y = 3;
            int tmp = x;
            x = y;
            y = tmp;
        }
    }
}
