using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class PlusEx1
    {
        static void Main(string[] args)
        {
            int k = 5;
            int p = k++;
            Console.WriteLine($"k={k}, p={p}"); //k = 6, p = 5
        }
    }
}
