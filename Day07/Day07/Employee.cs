using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    public class Employee : IComparable, IComparable<Employee>
    {
        int empID;
        public int EmpID { get { return empID; }  }
        public string Name { get; set; }
        public long Salary { get; private set; }
        public string Address { get; set; }

        public Employee()
        {
            empID = 23015;
            Salary = 3500;
        }
        public Employee(int empID, string empName)
        {
            this.empID = empID;
            this.Name = empName;
        }
        public Employee(int empID, long salary)
        {
            this.empID = empID;
            Salary = salary;
        }

        public Employee(int empID, string empName, long salary)
        {
            this.empID = empID;
            this.Name = empName;
            this.Salary = salary;
        }

        public virtual int GetMonthSalary()
        {
            return (int)(this.Salary * 10000 / 12);
        }

        public override string ToString()
        {
            return $"사원번호:{empID} 사원명:{Name} 연봉:{Salary} 주소:{Address}";
        }

        public int CompareTo(Employee other) //IComparable<T>
        {
            return this.EmpID.CompareTo(other.EmpID);
        }

        public int CompareTo(object obj)  //IComparable
        {
            //나의 사번과 다른 사번을 비교해서 -1, 0, 1 을 반환
            if (obj is Employee other)
            {
                return this.EmpID.CompareTo(other.EmpID);
            }
            else
                return 0;

        }
    }

    public class SalesEmployee : Employee
    {
        public double Incentive { get; private set; }

        public SalesEmployee(int empID, long salary, double incentive) : base(empID, salary)
        {
            Incentive = incentive;
        }

        public override int GetMonthSalary()
        {
            int m_salary = base.GetMonthSalary();
            return (int)Math.Round(m_salary * this.Incentive * 0.01, 0);
        }        

        public bool EqualEmployee(SalesEmployee other)
        {
            if (this.EmpID == other.EmpID)
                return true;
            else
                return false;            
        }

        public override string ToString()
        {
            return $"사원번호:{EmpID} 연봉:{Salary} 주소:{Address} 인센티브:{Incentive}";
        }

        public override bool Equals(object obj)
        {//사원번호가 동일하면 true
            SalesEmployee other = obj as SalesEmployee;
            if (other != null)
            {
                if (this.EmpID == other.EmpID)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {//사원번호가 같으면 같은 int값이 나와야 한다.
            return EmpID.GetHashCode() + 284491835;
        }

        public static bool operator == (SalesEmployee s1, SalesEmployee s2)
        {
            if ((object)s1 != null && (object)s2 != null)
            {
                return s1.Equals(s2);
            }
            else
                return false;
        }

        public static bool operator != (SalesEmployee s1, SalesEmployee s2)
        {
            return !(s1 == s2);
            /*
            if (s1.EmpID != s2.EmpID)
                return true;
            else
                return false; */
        }
    }
}
