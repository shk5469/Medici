using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] grade = { 87, 67, 59 };
            int sum;
            sum = grade.Sum();
            Console.WriteLine(sum);

            int[] arr = new int[11]; //배열 생성 후 0으로 초기화
            Console.WriteLine(arr.Length);

            string[] beers = new string[5];

            for (int i = 0; i < beers.Length; i++)
                beers[i] = Console.ReadLine();
            foreach (string e in beers)
                Console.Write(e + ", ");
        }
    }
}
