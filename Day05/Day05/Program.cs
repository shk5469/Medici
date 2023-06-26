using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            //가로 세로 길이를 입력받아서 정사각형의 넓이와 둘레를 구하는 메서드를 구현
            Console.Write("가로:");
            int width = int.Parse(Console.ReadLine());

            Console.Write("세로:");
            int height = int.Parse(Console.ReadLine());

            int sq, ar;
            Program pg = new Program();
            pg.RecCalc(width, height, out sq, out ar);

            Console.WriteLine(sq + "  /  " + ar);

            //(int sq, int ar) = RecCalc(width, height);
        }

        void RecCalc(int w, int h, out int sq, out int ar)
        {
            sq = w * h;
            ar = (2 * w) + (2 * h);
        }

        /*
        static (int, int) RecCalc(int w, int h)
        {
            int sq = w * h;
            int ar = (2 * w) + (2 * h);
            return (sq, ar);
        }
        */
    }
}
