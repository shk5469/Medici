using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Util
    {
        public static int WordLength(string str)
        {
            string[] words = str.Trim().Split(' ');
            return words.Length;
        }
    }
}
