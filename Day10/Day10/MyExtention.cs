using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    static class MyExtention
    {
        public static int WordLength(this string str)
        {
            string[] words = str.Trim().Split(' ');
            return words.Length;
        }

        public static bool IsNumber(this string str)
        {
            int num;
            if (int.TryParse(str, out num))
                return true;
            else
                return false;
        }
    }
}
