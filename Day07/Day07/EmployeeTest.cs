using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 2, 6, 8, 3, 10 };
            Array.Sort(nums);
            Console.WriteLine(string.Join(",", nums));

            Employee eee = new Employee
            {
                Name = "홍길동",
                Address = "인천시"
            };


            Employee[] emps = new Employee[3];
            emps[0] = new Employee(1005, "홍길동");
            emps[1] = new Employee(1006, "김길동");

            Employee[] arr = {
                new Employee(1009, "홍길동", 4000),
                new Employee(1016, "김길동", 5500),
                new Employee(1007, "박길동", 2000)
            };

            //Array.Sort(arr); //기본으로 Employee클래스에 정의된 비교 (CompareTo)
            //Array.Sort(arr, new EmployeeNameComparator());
            Array.Sort(arr, new EmployeeSalaryComparator());

            foreach (Employee temp in arr)
            {
                Console.WriteLine(temp);
            }

            List<Employee> list = new List<Employee>();
            list.Add(new Employee(1005, "홍길동"));
            list.Add(new Employee(1005, "홍길동"));
            Console.WriteLine(list.Count); //2

            HashSet<Employee> set = new HashSet<Employee>();
            set.Add(new Employee(1005, "홍길동"));
            set.Add(new Employee(1005, "홍길동"));
            Console.WriteLine(set.Count);  //2

            //HashSet은 중복여부를 체크해서, 중복이 안될때만 추가
            //중복여부를 체크하는 기준은 Equals(), GetHashCode()를 호출한 결과가 동일하면 중복으로 판단
            HashSet<SalesEmployee> set2 = new HashSet<SalesEmployee>();
            set2.Add(new SalesEmployee(1005, 2000, 500));
            set2.Add(new SalesEmployee(1005, 3000, 600));
            Console.WriteLine(set2.Count);  //1

            HashSet<int> testSet = new HashSet<int>();
            testSet.Add(30);
            testSet.Add(30);
            Console.WriteLine(testSet.Count); //1

            SalesEmployee se5 = new SalesEmployee(1009, 5000, 400);
            SalesEmployee se6 = new SalesEmployee(1019, 5000, 400);

            Console.WriteLine(se5.GetHashCode());
            Console.WriteLine(se6.GetHashCode());
        }
    }
}
