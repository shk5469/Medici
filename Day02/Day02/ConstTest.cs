using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class ConstTest
    {
        static void Main(string[] args)
        {
            const double PI = 3.141592;
            double radius;
            Console.WriteLine("원의 반지름: ");
            radius = double.Parse(Console.ReadLine());

            double square = PI * radius * radius;
            double area = 2 * PI * radius;

            Console.WriteLine($"반지름이 {radius}인 원의 넓이는 {square:f2}이고, 둘레는 {area:f2} 입니다.");

            int r = 5;
            Console.WriteLine(r*r*PI);
        }
    }
}
