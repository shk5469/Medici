using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ForEx2
    {
        static void Main(string[] args)
        {
            //1부터 100까지의 수중에서 5의 배수의 합을 구하시오.
            int sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine($"1부터 100사이에 있는 5의 배수들의 합: {sum}");
            //1부터 100까지의 수중에서 2의 배수이거나 3의 배수의 합을 구하시오
            sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0 || i % 3 == 0)
                    sum += i;
            }
            Console.WriteLine($"1부터 100사이에 있는 2의 배수이거나 3의 배수들의 합: {sum}");
            //1부터 100까지의 수중에서 3의 배수이거나 5의 배수를 출력하고, 합을 구하시오.
            sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"1부터 100사이에 있는 3의 배수이거나 5의 배수들의 합: {sum}");
            //1부터 100까지의 수중에서 3의 배수이거나 5의 배수가 아닌 것을 출력하시오.
            sum = 0;
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    continue;
                Console.WriteLine(i);
            }
            //구구단을 가로로 출력하시오
            for (int i = 1; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {
                    Console.Write($" {j} * {i} = {i * j, 2} |");
                }
                Console.WriteLine();
            }
        }
    }
}
