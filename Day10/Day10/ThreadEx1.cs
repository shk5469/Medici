using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day10
{
    class ThreadEx1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("메인시작");

            Thread t1 = new Thread(Sum);
            t1.IsBackground = true;
            Console.WriteLine("쓰레드호출 전");
            t1.Start();            
            Console.WriteLine("쓰레드호출 후");
            Console.WriteLine("메인종료");
        }

        static void Sum()
        {
            Console.WriteLine("쓰레드메서드 시작");

            int tot = 0;
            for(int i=0; i<100000000; i++)
            {
                tot += i;
                //Thread.Sleep(100);
            }

            Console.WriteLine("쓰레드메서드 종료");
        }
    }
}
