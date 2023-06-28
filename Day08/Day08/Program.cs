using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class Person
    {
        public string Name { get; set; } = "무명씨";
        public int Age { get; set; } = 1;

        public Person() { }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("강감찬", 500);
            p1.Name = "강강강";

            Person p2 = new Person();

            Person p3 = new Person {
                Name = "아무개",
                Age = 20 
            };

        }
    }
}
