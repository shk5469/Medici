using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class Util
    {
        public static void CopyArray<T1>(T1[] source, T1[] target)
        {
            for(int i=0; i<source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }

    class GenericTest
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 7 };
            int[] newArr = new int[5]; //참조타입은 초기화

            Util.CopyArray(arr, newArr);

            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            string[] org = { "a", "b", "d" };
            string[] target = new string[6];

            Util.CopyArray<string>(org, target);

        }
    }
}
