using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    delegate int Comparer(int a, int b);

    class DelegateEx1
    {
        static void Main(string[] args)
        {            
            int[] arr = { 3, 7, 4, 2, 10 };

            BubbleSort(arr, AscendCompare);
            Console.WriteLine(string.Join(",", arr));

            BubbleSort(arr, DesendCompare);
            Console.WriteLine(string.Join(",", arr));
        }

        static void BubbleSort(int[] arr, Comparer compare)
        {
            int temp = 0;
            for (int i=0; i<arr.Length-1; i++)
            {
                for(int j=0; j<arr.Length-(i+1); j++)
                {
                    if (compare(arr[j], arr[j+1]) > 0)
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DesendCompare(int a, int b)
        {
            if (a > b)
                return -1;
            else if (a == b)
                return 0;
            else
                return 1;
        }
    }
}
