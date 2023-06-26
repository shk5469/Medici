using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class A
    {
        int a, b, c;

        public A() : this(5, 10)
        { }

        public A(int b) : this(b, 10)
        { }

        public A(int b, int c)
        {
            a = 5425;
            this.b = b;
            this.c = c;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();
            acc1.AccNum = "1234-2345-45";
            acc1.Name = "홍길동";

            BankAccount acc2 = new BankAccount("2222-3333", "김연아", 10000000);

            Console.WriteLine(acc1.PrintAccInfo());
            Console.WriteLine(acc2.PrintAccInfo());

            acc1.InputMoney(500);

            ResultMessage result = null;
            
            result = ProcessOutput(acc1, 1000);
            result = ProcessOutput(acc2, 1000);
        }

        private static ResultMessage ProcessOutput(BankAccount acc, int amount)
        {
            ResultMessage result = acc.OutputMoney(amount);
            if (result.ErrCode != "0")
            {
                Console.WriteLine(result.ErrMsg);
            }
            else
            {
                Console.WriteLine("출금이 완료되었습니다.");
                Console.WriteLine(acc.PrintAccInfo());
            }

            return result;
        }
    }
}
