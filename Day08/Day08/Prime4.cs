using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day08_4
{
    public delegate void PrimeDelegate(int num);
    class Calc
    {        
        //이벤트 정의
        //public event 델리게이트명 이벤트명;
        public event PrimeDelegate Prime;

        //이벤트 발생
        public void GetPrimeNumber(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                bool result = IsPrimeNumber(i);
                if (result)
                {
                    //이벤트 발생 
                    if (Prime != null) //사용하는 클래스쪽에서 등록된 이벤트핸들러가 있다면
                    {
                        Prime(i);
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
        }

        public bool IsPrimeNumber(int inputNum)
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

    class Prime4
    {
        //이벤트핸들러 등록
        //이벤트핸들러 구현
        static void Main(string[] args)
        {
            Calc c1 = new Calc();

            //이벤트핸들러 등록
            c1.Prime += PrintPrime;

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

                c1.GetPrimeNumber(int.Parse(from), int.Parse(to));

                Console.WriteLine();
                //bool result = Calc.IsPrimeNumber(int.Parse(input));

                //if (result)
                //    Console.WriteLine("솟수입니다.");
                //else
                //    Console.WriteLine("솟수가 아닙니다.");
            }
        }

        //이벤트핸들러 구현
        private static void PrintPrime(int num)
        {
            Console.Write(num + " ");
        }
    }
}
