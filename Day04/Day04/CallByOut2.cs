using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class CallByOut2
    {
        const double PI = 3.14;
        static void Main(string[] args)
        {
            int radius;
            double area;
            Console.Write("반지름: ");
            int.TryParse(Console.ReadLine(), out radius);

            Console.WriteLine($"원의 둘레: {Circle(radius, out area)}, 원의 넓이: {area}");
        }

        static double Circle(int radius, out double area)
        {
            area = radius * radius * PI;

            return radius * PI * 2;
        }
    }
}
