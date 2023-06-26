using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_2
{
    class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }

        //public Employee() { }
        public Employee(int no, string name)
        {
            this.EmpNo = no;
            this.EmpName = name;
        }

        // virtual => 가상메서드
        // 자식이 재정의 할수도 있고 안할수도 있다. (선택)

        // abstract => 추상메서드
        // 부모는 구현을 안하고, 무조건 자식이 재정의해야만 한다. (필수)
        public virtual void PrintInfo()
        {
            Console.WriteLine($"{this.EmpName} - {this.EmpNo}");
        }
    }

    class SalesEmployee : Employee
    {
        public int Incentive { get; set; }
        
        public SalesEmployee() : base(1, "아무개")
        {
            Incentive = 100;
        }
    }

    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(100, "bbb");

            //자식의 객체를 생성할때, 부모의 생성자가 먼저 호출되고 난 후 자식의 생성자가 실행된다.
            //자식의 생성자는 기본적으로 부모의 기본생성자를 호출한다.
            //이때 부모의 기본생성자가 없는 경우에는 에러가 발생한다. => 기본생성자는 기본으로 정의해두는 습관이 좋다.
            //부모의 기본생성자가 없는 경우에는 base() 를 사용해서 적절한 부모의 생성자를 호출한다.
            SalesEmployee s1 = new SalesEmployee();
            s1.Incentive = 500;
            s1.PrintInfo();
        }
    }
}
