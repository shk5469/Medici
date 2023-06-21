using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class IF2
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(rand.Next(1, 46) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
