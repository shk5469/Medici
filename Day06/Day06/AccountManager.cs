using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class AccountManager
    {
        BankAccount account;

        public void PrintMenu()
        {
            Console.WriteLine("============== Menu ==============");
            Console.WriteLine("1. 계좌 개설");
            Console.WriteLine("2. 입금");
            Console.WriteLine("3. 출금");
            Console.WriteLine("4. 잔액 조회");
            Console.WriteLine("5. 프로그램 종료");
        }

        public void MakeAccount()   //계좌 개설
        {
            Console.Write("계좌번호:");
            string num = Console.ReadLine();
            Console.Write("예금주명:");
            string name = Console.ReadLine();

            account = new BankAccount(num, name);
            Console.WriteLine("계좌가 개설되었습니다.");
        }

        public void Deposit()   //입금처리
        {
            if (account == null)
            {
                Console.WriteLine("계좌 개설을 먼저 해주십시오.");
                return;
            }
            Console.Write("입금하실 금액은? :");
            int money = int.Parse(Console.ReadLine());
            account.InputMoney(money);
            Console.WriteLine("입금이 정상 처리되었습니다.");
        }

        public void Withdraw()  //출금처리
        {
            if (account == null)
            {
                Console.WriteLine("계좌 개설을 먼저 해주십시오.");
                return;
            }

            Console.Write("출금하실 금액은? :");
            int money = int.Parse(Console.ReadLine());
            ResultMessage result = account.OutputMoney(money);
            if (result.ErrCode != "0")
            {
                Console.WriteLine(result.ErrMsg);
            }
            else
            {
                Console.WriteLine("출금이 정상 처리되었습니다.");
                Console.WriteLine(account.PrintAccInfo());
            }
        }

        public void GetBalance()    //잔액조회처리
        {
            if (account == null)
            {
                Console.WriteLine("계좌 개설을 먼저 해주십시오.");
                return;
            }

            Console.WriteLine(account.PrintAccInfo());
        }
    }
}
