using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program_Class2
    {
        static void Main(string[] args)
        {
            //가로 세로 길이를 입력받아서 정사각형의 넓이와 둘레를 구하는 메서드를 구현
            Console.Write("가로:");
            int width = int.Parse(Console.ReadLine());

            Console.Write("세로:");
            int height = int.Parse(Console.ReadLine());

            MyRectangle r1 = new MyRectangle();
            r1.width = width;
            r1.height = height;

            Console.WriteLine(r1.GetSquare() + "  /  " + r1.GetArea());
        }
    }
}
