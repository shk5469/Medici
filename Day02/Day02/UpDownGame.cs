using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class UpDownGame
    {
        const int CHANCE = 6;
        static void Main(string[] args)
        {
            bool start = true;
            int cnt = 0, score = 0;
            string answer;
            while (start)
            {
                Console.Write("게임을 진행하시겠습니까?(예/아니오) :");
                answer = Console.ReadLine();
                if (answer == "예")
                {
                    cnt++;
                    score += Start();
                }
                else if (answer == "아니오")
                {
                    Console.WriteLine($"총 점수는 {score}이며 승률은 {(int)(100.0 * score / cnt)}%입니다.");
                    start = false;
                }
            }
        }
        static int Start()
        {
            Random rnd = new Random();
            int answer = rnd.Next(1, 51);
            int res;
            Console.WriteLine(answer);
            Console.WriteLine($"업다운 게임을 시작하겠습니다. 기회는 {CHANCE}번입니다.(범위: 1~50)");

            for (int i = 0; i < CHANCE; i++)
            {
                Console.Write("숫자를 입력해주세요: ");
                res = int.Parse(Console.ReadLine());

                if (res < 1 || res > 50)
                {
                    Console.WriteLine("범위를 초과하셨습니다.");
                    i--;
                    continue;
                }
                if (res < answer)
                    Console.WriteLine("업");
                else if (res > answer)
                    Console.WriteLine("다운");
                else
                {
                    Console.WriteLine("정답입니다!!");
                    return 1;
                }
            }
            Console.WriteLine($"정답은 {answer}입니다.");

            return 0;
        }
    }
}
