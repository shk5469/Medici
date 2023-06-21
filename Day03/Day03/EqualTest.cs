using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class EqualTest
    {
        static void Main(string[] args)
        {
            MyTest t1 = new MyTest();
            t1.num = 30;
            MyTest t2 = new MyTest();
            t2.num = 30;

            //다르다
            if (t1 == t2)
                Console.WriteLine("같다.");
            else
                Console.WriteLine("다르다.");

            //같다
            if (t1.num == t2.num) //t1.Equals(t2)
                Console.WriteLine("같다.");
            else
                Console.WriteLine("다르다.");
        }
    }
    class MyTest
    {
        public int num = 10;
        public override bool Equals(object obj)
        {
            return obj is MyTest test &&
                num == this.num;
        }
    }
}
