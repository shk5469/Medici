using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class LinqEx1
    {
        static List<Person> people;
        static List<MainLanguage> languages;

        static void InitData()
        {
            people = new List<Person>
            {
                new Person{Name = "Tom", Age = 63, Address = "Korea"},
                new Person{Name = "Winnie", Age = 40, Address = "Tibet"},
                new Person{Name = "Anders", Age = 47, Address = "Sudan"},
                new Person{Name = "Hans", Age = 25, Address = "Korea"},
                new Person{Name = "Eureka", Age = 32, Address = "Sudan"},
                new Person{Name = "Kang", Age = 15, Address = "Korea"}
            };

            languages = new List<MainLanguage>
            {
                new MainLanguage {Name = "Anders", Language = "Delphi"},
                new MainLanguage {Name = "Anders", Language = "C#"},
                new MainLanguage {Name = "Tom", Language = "Borland C++"},
                new MainLanguage {Name = "Hans", Language = "Visual C++"},
                new MainLanguage {Name = "Winnie", Language = "R"}
            };
        }

        static void Main(string[] args)
        {
            InitData();//people, languages

            //var list = (from per in people
            //            where per.Address == "Korea"
            //            select per);

            people.ForEach((p)=> Console.WriteLine(p));

            foreach(Person p in people)
            {
                if (p.Address == "Korea")
                    Console.WriteLine(p);
            }

            Person temp = people.FirstOrDefault<Person>();
            Console.WriteLine(temp);

            var list = people.FindAll((p) => p.Address == "Korea");

            Console.WriteLine(string.Join(",", list));

            //40세 이하 개발자를 출력하시오.
            //메서드의 매개변수 타입이 델리게이트인 메서드는 람다식으로 전달
            people.FindAll((p) => p.Age <= 40).ForEach((p) => Console.WriteLine(p));

            //address별로 그룹핑해서 출력
            var grp = people.GroupBy((p) => p.Address);
            foreach (var item in grp)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("---------------");
                foreach(var elem in item)
                {
                    Console.WriteLine(elem);
                }
            }

            //address별로 그룹핑해서 그룹당 몇명인지 출력 
            people.GroupBy((p) => p.Address)
                .Select((n) => new { Name = n.FirstOrDefault().Address, Cnt = n.Count() })
                .ToList().ForEach((g) => Console.WriteLine(g.Name + "===" + g.Cnt));
        }
    }
}