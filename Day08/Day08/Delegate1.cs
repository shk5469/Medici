using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    delegate int Sample(int x1, int x2);
    delegate void SampleHandler(int y);

    class MyClass
    {
        public int Plus(int x, int y)
        {
            return x + y;
        }

        public int Minus(int x, int y)
        {
            return x - y;
        }

        public void Divide(int x)
        {
            int a = x  / 10 ;
        }
    }

    class Delegate1
    {
        static void Main(string[] args)
        {
            MyClass c1 = new MyClass();
            int result = c1.Plus(3, 8);
            result = c1.Minus(8, 5);

            //Sample d = new Sample(c1.Minus);
            Sample d = c1.Minus;
            d += c1.Plus;
            //d += c1.Divide;
            Console.WriteLine( d(10, 5) );
            d -= c1.Plus;
            Console.WriteLine(d(10, 5));


            SampleHandler sd = null;

            if (sd != null)
            {
                sd(10);
            }
        }
    }
}
