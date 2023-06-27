using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    class EmployeeSalaryComparator : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x != null && y != null)
            {
                return x.Salary.CompareTo(y.Salary);
            }
            else
            {
                return 0;
            }
        }
    }

    class EmployeeNameComparator : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x != null && y != null)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return 0;
            }
        }
    }
}
