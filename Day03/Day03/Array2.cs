using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Array2
    {
        static void Main(string[] args)
        {
            string[] arr = { "딸기", "사과", "수박", "참외" };
            foreach (string e in arr)
                Console.WriteLine(e);

            double[] score = new double[5] { 78.4, 89.0, 56.9, 89.9, 90.5 };
            foreach(double e in score)
                Console.WriteLine(e);
        }
    }
}
