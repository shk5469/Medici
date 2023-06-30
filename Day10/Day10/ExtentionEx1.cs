using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class ExtentionEx1
    {
        static void Main(string[] args)
        {
            string str = "delegate int Comparer (int a, int b)";
            Console.WriteLine(str.Length);

            Console.WriteLine(str.WordLength()); //확장메서드 사용

            Console.WriteLine(Util.WordLength(str)); //일반메서드 사용

            //사용자에게 수를 입력받아서 숫자인지 여부를 반환
            Console.Write("수 입력:");
            string input = Console.ReadLine();
            if (! input.IsNumber())
                Console.WriteLine("수가 아닙니다.");
        }

        
    }
}
