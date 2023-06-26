using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Mammal
    {
        public virtual void Sound()
        {
            Console.WriteLine("소리를 낸다.");
        }
    }

    class Dog : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Mammal
    {
        public override void Sound()
        {
            Console.WriteLine("야옹");
        }
    }


    class Reference_Convert
    {
        static void Main(string[] args)
        {
            Mammal m1 = new Mammal();
            m1.Sound();

            Dog d1 = new Dog();
            d1.Sound();

            Cat c1 = new Cat();
            c1.Sound();

            Mammal m2 = d1;

            //Dog d2 = (Dog)m1; // System.InvalidCastException
            //d2.Sound();

            Dog d2 = (Dog)m2;
            d2.Sound();

            //부모를 자식으로 형변환할때는 가능하거나 가능하지 않으므로, 무조건 형변환을 하지말고...안전한 코딩을 해야만 한다.
            // is, as 를 이용해야 한다.

            if (m1 is Dog) // is => true, false 를 반환
            {
                Dog d22 = (Dog)m1;
                d22.Sound();
            }
            //최신 is 구문
            if (m1 is Dog d44)
            {
                d44.Sound();
            }


            Dog d33 = m2 as Dog; // as => 형변환을 한 결과를 반환 (만일 형변환을 실패했다면 null을 반환, 에러발생안함) 
            if (d33 != null)
            {
                d33.Sound();
            }
        }
    }
}
