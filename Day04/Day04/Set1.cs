using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Set1
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            Random rnd = new Random();
            while (set.Count() < 7)
            {
                set.Add(rnd.Next(1, 46));
            }

            foreach(int e in set)
                Console.WriteLine(e);
        }
    }
}
