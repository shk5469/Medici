using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    static class MyExtension
    {
        public static bool isNum(this string s)
        {
            int n;
            return int.TryParse(s, out n);
        }
    }
}
