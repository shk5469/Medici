using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07_2
{
    interface IFly
    {
        void Fly();
    }

    interface IRun
    {
        void Run();
    }

    class FlyingBike : IFly, IRun
    {
        public void Fly()
        {
            Console.WriteLine("bike Fly");
        }

        public void Run()
        {
            Console.WriteLine("bike Run");
        }
    }

    class FlyingCar : IFly, IRun
    {
        public void Fly()
        {
            Console.WriteLine("car Fly");
        }

        public void Run()
        {
            Console.WriteLine("car Run");
        }
    }

    class InterfaceTest
    {
        static void Main(string[] args)
        {
            FlyingBike b1 = new FlyingBike();
            b1.Fly();

            FlyingCar c1 = new FlyingCar();
            c1.Fly();

            IFly f1 = b1;
            f1.Fly(); //다형성

            f1 = c1;
            f1.Fly(); //다형성

            Flying(b1);
            Flying(new FlyingBike());
        }

        static void Flying(IFly fly)
        {
            fly.Fly(); //다형성, override
        }
    }
}
