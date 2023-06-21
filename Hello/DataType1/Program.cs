using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType1
{
    class Program
    {
        static void Main(string[] args)
        {
            float f1 = 0.1f;

            for(int i = 0; i<10; i++)
            {
                f1 += 0.1f;
            }

            Console.WriteLine(f1);

        }
    }
}
