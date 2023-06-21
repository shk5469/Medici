using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer, cnt, score = 0;
            string res;
            Random rnd = new Random();

            for (cnt = 0; cnt < 5; cnt++)
            {
                answer = rnd.Next(1, 101);
                Console.Write("홀 or 짝: ");
                res = Console.ReadLine();

                #region if문 연습
                //삼항연산자 (조건) ? 참:거짓
                #endregion
                if (!(res == "홀" || res == "짝"))
                {
                    Console.WriteLine("다시 입력하세요.");
                    cnt--;
                    continue;
                }

                if (res == "홀" && answer % 2 != 0)
                {
                    Console.WriteLine("정답입니다.");
                    score++;
                }
                else if (res == "짝" && answer % 2 == 0)
                {
                    Console.WriteLine("정답입니다.");
                    int j = 0;
                    score++;
                }
                else
                    Console.WriteLine("틀렸습니다.");
            }
            Console.WriteLine(j);
            Console.WriteLine($"{score}승 {cnt - score}패 승률 {(int)((double)score / (float)cnt * 100)}%입니다.");
        }
    }
}