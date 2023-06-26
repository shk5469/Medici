using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class ProgramManage
    {
        static void Main(string[] args)
        {
            AccountManager am = new AccountManager();
            bool bContinue = true;
            while (bContinue)
            {
                am.PrintMenu();
                Console.Write("선택: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: am.MakeAccount(); break;
                    case 2: am.mDeposit(); break;
                    case 3: am.mWithdraw(); break;
                    case 4: am.GetBalance(); break;
                    case 5: bContinue = false; break;
                    default: Console.WriteLine("다시 선택하세요."); break;
                }
            }
            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
