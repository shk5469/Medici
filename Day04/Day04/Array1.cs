using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] arr2 = new int[6];
            int n;
            Random rnd = new Random();

            int idx = 0;

            while(idx < arr2.Length)
            {
                n = rnd.Next(1, 7);

                if (Array.IndexOf(arr2, n) == -1)
                {
                    arr2[idx] = n;
                    idx++;
                }
            }
            
            foreach (int e in arr2)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            Array.Sort(arr2);

            foreach (int e in arr2)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}
