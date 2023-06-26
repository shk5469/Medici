using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Program_Manager
    {
        static void Main(string[] args)
        {
            AccountManager manager = new AccountManager();
            bool bContinue = true;

            while(bContinue)
            {
                manager.PrintMenu();
                Console.Write("선택: ");
                int choice = int.Parse(Console.ReadLine());

                switch(choice)
                {
                    case 1: manager.MakeAccount(); break;
                    case 2: manager.Deposit(); break;
                    case 3: manager.Withdraw(); break;
                    case 4: manager.GetBalance(); break;
                    case 5: bContinue = false; break;
                    default: Console.WriteLine("다시 선택하세요."); break;
                }
            }

            Console.WriteLine("프로그램을 종료합니다.");
        }
    }
}
