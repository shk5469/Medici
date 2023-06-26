using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{Name} - {Age}");
        }
    }

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("김우빈", 32);
            p1.PrintInfo();

            Person p2 = new Person("신민아", 30);
            p2.PrintInfo();

            Person p3 = p1;
            if (p3 == p1)
                Console.WriteLine("같은 사람입니다.");
            else
                Console.WriteLine("다른 사람입니다.");

            p3.Age = 50;
            p1.PrintInfo();

            Person p4 = new Person("김우빈", 50);
            p4.PrintInfo();

            if (p4 == p1)
                Console.WriteLine("같은 사람입니다.");
            else
                Console.WriteLine("다른 사람입니다.");
        }
        
    }
}
