using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ForEx1
    {
        static void Main(string[] args)
        {
            //합
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //원하는 단 출력
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");
            }
            Console.WriteLine("---------------");

            //구구단
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                    Console.WriteLine($"{i} * {j} = {i * j}");
                Console.WriteLine("---------------");
            }

            //1~10까지의 짝수의 합을 구하시오.
            sum = 0;
            for (int i = 2; i < 11; i+=2)
            {
                sum += i;
            }
            Console.WriteLine(sum);

            //1부터의 합이100보다 커지는 순간의 수를 구하시오.
            sum = 0;
            int a = 1;
            while (sum <= 100)
            {
                sum += a++;
            }
            Console.WriteLine($"1 부터 {a-1}까지의 합은 {sum}입니다.");

        }
    }
}
