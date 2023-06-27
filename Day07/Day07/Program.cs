using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Address = "서울시 금천구 가산";

            Console.WriteLine(emp1);
            Console.WriteLine(emp1.GetMonthSalary());

            SalesEmployee se1 = new SalesEmployee(23020, 4500, 150);
            Console.WriteLine(se1); //사원번호:23020 연봉:4500 주소:
            Console.WriteLine(se1.GetMonthSalary());
                        
            SalesEmployee se2 = new SalesEmployee(23020, 4500, 150);
            Console.WriteLine(se1 == se2); //True
            Console.WriteLine(se1.Equals(se2)); //True
        }
    }
}
