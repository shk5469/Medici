using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    class Employee : Person
    {
        public int EmpNo { get; set; }

        public override void PrintInfo()
        {
           // base.PrintInfo();
            Console.WriteLine($"{Name} - {Age} - {EmpNo}");
        }
    }

    class EmployeeTest
    {
        static void Main(string[] args)
        {
            /*Object obj = 10;
            obj = "hello";
            obj = e1;*/

            //참조 => 참조 형변화
            //1. 자식이 부모로 형변환 (암시적으로 100% 성공)
            //2. 부모가 자식으로 형변환 (무조건 명시적형변환을 해야만 한다.)
            //      명시적형변환을 해도 실행중 경우에 따라서 예외가 발생할 수 있고 성공할 수도 있다
            //       => (형변환하려는 변수의 태생에 따라서 달라진다)

            Employee e1 = new Employee();
            e1.Name = "김신";
            e1.Age = 420;
            e1.EmpNo = 10001;
            e1.PrintInfo();  //김신 - 420 - 10001

            //자식이 부모로 형변환 (암시적으로 100% 성공)
            Person p1 = e1;
            p1.PrintInfo();  //김신 - 420

            Employee e2 = (Employee)p1; //형변환 성공 
            e2.PrintInfo(); //김신 - 420 - 10001
            PlusAge(e2);

            Person p2 = new Person("오류남", 20);
            //Employee e3 = (Employee)p2; //형변환 오류

           
        }

        static void PlusAge(Person per)
        {
            per.Age = per.Age + 1;
            per.PrintInfo(); //김신 - 421 - 10001    
            //PrintInfo() 자식에서 new 키워드로 정의했을때
            //무조건 메서드를 호출할때의 액면 타입으로만 결정
            //김신 - 421

            //virtual - override 재정의하면,
            //호출하는 변수의 태생에 따라서 해당하는 타입으로 결정
        }
    }
}
