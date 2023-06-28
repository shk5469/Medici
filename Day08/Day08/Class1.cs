using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class Class1
    {
        static void Main(string[] args)
        {
            string uid = string.Empty;
            string pwd = string.Empty;

            Console.Write("아이디:");
            uid = Console.ReadLine();

            Console.Write("비밀번호:");
            pwd = Console.ReadLine();

#if DEBUG
            uid = "admin";
            pwd = "1234";
#endif
            //uid, pwd  를 DB전달해서 주문내역
            Console.WriteLine("당신의 주문내역");
            System.Diagnostics.Trace.WriteLine("dfsdfsdf");
        }
    }
}
