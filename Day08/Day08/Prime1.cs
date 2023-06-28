using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08
{
    class Calc
    {
        public static bool IsPrimeNumber(int inputNum)
        {
            bool bPrime = true;

            if (inputNum == 2)
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

    class Prime1
    {
        static void Main(string[] args)
        {
            //사용자에게 수를 입력받아서, 솟수인지 아닌지 판단해서 출력하시오.
            while (true)
            {
                Console.Write("숫자입력(종료:Q) : ");
                string input = Console.ReadLine();
                if (input.Equals("q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                bool result = Calc.IsPrimeNumber(int.Parse(input));

                if (result)
                    Console.WriteLine("솟수입니다.");
                else
                    Console.WriteLine("솟수가 아닙니다.");
            }
        }
    }
}
