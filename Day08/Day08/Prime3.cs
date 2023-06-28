using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_3
{
    class Calc
    {
        //1부터 100까지의 솟수를 모두 구하시오.
        public static List<int> GetPrimeNumber(int start, int end)
        {
            List<int> list = new List<int>();

            for (int i = start; i <= end; i++)
            {
                bool result = IsPrimeNumber(i);
                if (result)
                    list.Add(i);
            }

            return list;
        }

        public static bool IsPrimeNumber(int inputNum)
        {
            bool bPrime = true;

            if (inputNum == 1)
                bPrime = false;
            else if (inputNum == 2)
                bPrime = true;
            else if (inputNum % 2 == 0)
                bPrime = false;
            else
            {
                for (int i = 3; i < inputNum; i++)
                {
                    if (inputNum % i == 0)
                    {
                        bPrime = false;
                        break;
                    }
                }
            }

            return bPrime;
        }
    }

    class Prime3
    {
        static void Main(string[] args)
        {
            //사용자에게 수를 입력받아서, 솟수인지 아닌지 판단해서 출력하시오.
            while (true)
            {
                Console.Write("시작 숫자입력(종료:Q) : ");
                string from = Console.ReadLine();

                Console.Write("종료 숫자입력(종료:Q) : ");
                string to = Console.ReadLine();

                if (from.Equals("q", StringComparison.OrdinalIgnoreCase) 
                    || to.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                List<int> result = Calc.GetPrimeNumber(int.Parse(from), int.Parse(to));
                Console.WriteLine(string.Join(",", result));

                Console.WriteLine();
                //bool result = Calc.IsPrimeNumber(int.Parse(input));

                //if (result)
                //    Console.WriteLine("솟수입니다.");
                //else
                //    Console.WriteLine("솟수가 아닙니다.");
            }
        }
    }
}
