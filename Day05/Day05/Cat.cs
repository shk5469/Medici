using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    struct Cat
    {
        private static int id = 0;
        public string Name { get; set; }
        public string Color { get; set; }

        //public Cat()
        //{
        //    id++;
        //}

        public Cat(string name, string color)
        {
            id++;
            Name = name;
            Color = color;
        }

        //static 메서드는 클래스명.메서드명() => 인스턴스 생성과 무관하다.
        //static 메서드는 static 멤버만 참조 가능
        //public static void PrintInfo()

        //인스턴스 메서드는 static멤버 + 인스턴스멤버 참조가능
        public void PrintInfo()
        {
            Console.WriteLine($"순번:{id}  이름:{Name}  색상:{Color}");
        }

        public string GetCatInfo()
        {
            return $"순번:{id}  이름:{Name}  색상:{Color}";
        }

        public void ChangeName(Cat cat)
        {
            Name = cat.Name;
        }
    }

    class CatTest
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.Name = "키티";
            c1.Color = "하얀색";
            c1.PrintInfo();
            

            Cat c2 = new Cat("네로", "검은색");
            c2.PrintInfo();

            c2.ChangeName(c1);
        }
    }
}
