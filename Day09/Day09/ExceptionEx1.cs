using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class ExceptionEx1
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("시작.....");
                AAA();
                Console.WriteLine("종료.....");
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private static bool AAA()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                return true;
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                return false;
            }
            finally //선택
            {
                Console.WriteLine("finally");
            }
        }
    }
}
