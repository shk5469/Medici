using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program_Class
    {
        static void Main(string[] args)
        {
            //가로 세로 길이를 입력받아서 정사각형의 넓이와 둘레를 구하는 메서드를 구현
            Console.Write("가로:");
            int width = int.Parse(Console.ReadLine());

            Console.Write("세로:");
            int height = int.Parse(Console.ReadLine());

            Rectangle r1 = new Rectangle();
            r1.width = width;
            r1.height = height;

            Rectangle r2 = RecCalc(r1);

            Console.WriteLine(r2.square + "  /  " + r2.area);
        }

        static Rectangle RecCalc(Rectangle r)
        {
            r.square = r.width * r.height;
            r.area = (2 * r.width) + (2 * r.height);

            return r;
        }
    }

    class Rectangle
    {
        public int width;
        public int height;
        public int square;
        public int area;
    }
}
