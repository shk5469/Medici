using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class IF1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("홀짝 게임을 시작합니다................");
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                int num = rand.Next(100);
                Console.Write("홀 or 짝 : ");
                string answer = Console.ReadLine();

                if (answer == "짝" && num % 2 == 0)
                    Console.WriteLine("정답입니다.");
                else if(answer == "홀" && num % 2 == 1)
                    Console.WriteLine("정답입니다.");
                else
                    Console.WriteLine("틀렸습니다");
            }

            Console.WriteLine("홀짝 게임을 종료합니다................");

        }
    }
}
