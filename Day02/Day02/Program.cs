using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 클래스의 Main");

            int i = 10;
            string str = "졸지마세요";
            int age = Convert.ToInt32("25"); //"25" -> 25

            object obj = 10;
            obj = "곧 쉬는시간. 화이팅";

            int x = 3;
            Change(x);
            Console.WriteLine(x);

            MyTest t = new MyTest();
            t.num = 3;
            Change(t);
            Console.WriteLine(t.num);

            string msg = "Hello";
            Change(msg);
            Console.WriteLine(msg);
        }

        static void Change(int k)
        {
            k += 10;
        }

        static void Change(MyTest k)
        {
            k.num += 10;
        }
        static void Change(string k)
        {
            k +=  "World";
            Console.WriteLine(k);
        }
    }

    class MyTest
    {
        public int num = 0;
    }
}