using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    abstract class Flyable
    {
        public override string ToString()
        {
            return base.ToString();
        }

        public abstract void Fly();
    }

    class FlyingBike : Flyable
    {
        public override void Fly()
        {
            Console.WriteLine("bike Fly");
        }
    }

    class FlyingCar : Flyable
    {
        public override void Fly()
        {
            Console.WriteLine("car Fly");
        }
    }

    class FlyingTest
    {
        static void Main(string[] args)
        {
            FlyingBike b1 = new FlyingBike();
            b1.Fly();           

            FlyingCar c1 = new FlyingCar();
            c1.Fly();

            Flyable f = b1;
            f.Fly();
            Flyable f2 = new FlyingCar();
            f2.Fly();

            Flying(b1);
            Flying(c1);
        }

        static void Flying(Flyable fly)
        {
            fly.Fly(); //다형성, override
        }
    }
}
