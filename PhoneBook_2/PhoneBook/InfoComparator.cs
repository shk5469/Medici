using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class InfoComparator : IComparer<PhoneInfo>
    {
        int n;

        public InfoComparator(int n)
        {
            this.n = n;
        }
        public int Compare(PhoneInfo x, PhoneInfo y)
        {
            if (x != null && y != null)
            {
                if (n == 1)
                    return x.Name.CompareTo(y.Name);
                else if (n == 3)
                    return x.PhoneNumber.CompareTo(y.PhoneNumber);
                else
                    return 0;
            }
            else
                return 0;
        }
    }
}
