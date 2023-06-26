using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06_3
{
    //클래스의 멤버중에 하나라도 abstract가 있으면 무조건 클래스는 추상클래스여야 한다.
    //멤버중에 abstract가 없어도, 클래스에 abstract를 붙여서 추상클래스로 만들수 있다.
    //추상클래스는 객체생성을 할 수 없다. 단, 변수타입으로 사용할 수 있다.
    abstract class Employee
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

        // abstract => 추상메서드  (구현은 없고 정의만 있다)
        // 부모는 구현을 안하고, 무조건 자식이 재정의해야만 한다. (필수)
        public abstract void PrintInfo();
    }

    class SalesEmployee : Employee
    {
        public int Incentive { get; set; }
        
        public SalesEmployee() : base(1, "아무개")
        {
            Incentive = 100;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{this.EmpName} - {this.EmpNo} - {Incentive}");
        }
    }

    class EmployeeTest
    {
        static void Main(string[] args)
        {
            //추상클래스는 객체 생성을 못한다. (new () 불가능)
            //Employee e1 = new Employee(100, "bbb");
            Employee e1 = new SalesEmployee();

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
