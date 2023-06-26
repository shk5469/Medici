using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class MyNum
    {
        public int X { get; set; }
        public int Y { get; set; }

        public MyNum DeepCopy()
        {
            MyNum new_copy = new MyNum();
            new_copy.X = X;
            new_copy.Y = Y;

            return new_copy;
        }
    }

    class Reference_Copy
{
        static void Change(MyNum m)
        {
            int temp = m.X;
            m.X = m.Y;
            m.Y = temp;
        }

        static void Main(string[] args)
        {
            MyNum m1 = new MyNum();
            m1.X = 5;
            m1.Y = 3;

            Console.WriteLine($"x:{m1.X}  y:{m1.Y}"); //5, 3

            //call by value => argument(인자)를 전달할때 값을 전달
            //1. 기본타입을 전달하는 경우  => 메서드의 실행결과가 영향을 안준다.
            //       => 기본타입을 전달할때 영향을 받고 싶으면 call by reference로 한다.
            //       => ref, out 키워드를 사용한다.

            //2. 참조타입을 전달하는 경우 => call by value 나 call by reference 동일하게 영향을 받는다.
            //       => 인자를 전달할때 얕은복사(단순복사)를 하기 때문에 영향을 받는다
            //       => 영향을 받지 않으려면 DeepCopy(깊은복사)를 해야한다.

            //깊은복사를 하려면 새로운 인스턴스를 생성한 후, 멤버 값을 복사한 후 전달
            //MyNum new_copy = new MyNum();
            //new_copy.X = m1.X;
            //new_copy.Y = m1.Y;

            //MyNum m = m1;
            Change(m1);

            Console.WriteLine($"x:{m1.X}  y:{m1.Y}"); //5, 3
        }
    }
}
