using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6];
            int[] arr2 = new int[6];
            int n;
            bool isOverlap = false;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                n = rnd.Next(1, 7);
                for (int j = 0; j < i; j++)
                {
                    if (arr[j] == n)
                    {
                        isOverlap = true;
                        i--;
                        break;
                    }
                }
                if (!isOverlap)
                    arr[i] = n;
                isOverlap = false;
            }

            int idx = 0;

            while(idx < arr2.Length)
            {
                n = rnd.Next(1, 7);
                for (int i = 0; i < idx; i++)
                {
                    if (arr2[i] == n)
                    {
                        isOverlap = true;
                        break;
                    }
                }
                if (!isOverlap)
                {
                    arr2[idx] = n;
                    idx++;
                }
                isOverlap = false;
            }

            foreach (int e in arr)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
            foreach (int e in arr2)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}
