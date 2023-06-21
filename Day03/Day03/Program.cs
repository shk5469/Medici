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
            int answer, cnt = 0, score = 0;
            string res;
            Random rnd = new Random();

            while (true)
            {
                answer = rnd.Next(1, 101);
                Console.Write("홀 or 짝(종료: 0): ");
                res = Console.ReadLine();

                #region if문 연습
                //삼항연산자 (조건) ? 참:거짓
                #endregion
                if (!(res == "홀" || res == "짝"))
                {
                    if (res == "0")
                        break;
                    Console.WriteLine("다시 입력하세요.");
                    continue;
                }

                cnt++;
                if ((res == "홀" && answer % 2 != 0) ||
                    (res == "짝" && answer % 2 == 0))
                {
                    Console.WriteLine("정답입니다.");
                    score++;
                }
                else
                    Console.WriteLine("틀렸습니다.");
            }
            Console.WriteLine($"{cnt}전 {score}승 승률 {(int)(100.0 * score / cnt)}%입니다.");
        }
    }
}