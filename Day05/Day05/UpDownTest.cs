using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class UpDownTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("게임을 시작합니다....");
            UpDownGame game = new UpDownGame();

            UpDownGameResult result;
            do
            {
                Console.Write("숫자:");
                int input = int.Parse(Console.ReadLine());

                result = game.Game(input);

                Console.WriteLine(game.Com + " / " + result);
            } while (result != UpDownGameResult.OK);

            Console.WriteLine("게임을 종료합니다....");
        }
    }
}
