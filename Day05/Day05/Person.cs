using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
    class Person
    {
        private string blood;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age, string blood="A")
        {            
            this.Name = name;
            Age = age;

            this.blood = blood;
        }

        public Person DeepCopy()
        {
            return new Person(Name, Age);
        }
    }

    class PersonTest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Alice", 30);
            //Person p2 = p1;  //얕은복사

            Person p2 = p1.DeepCopy(); //깊은복사 (인스턴스를 새로 생성해서 멤버를 복사한 것을 전달) 
            p2.Name = "Bob";

            Console.WriteLine($"{p1.Name}   {p2.Name}"); //Alice, Bob
        }
    }
}
