using System;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int cnt = 0;

            for (int i = 1; i <= n; i++)
            {
                if(i%5==0)
                    cnt++;
                if(i % 25 == 0)
                    cnt++;
                if(i % 125 == 0)
                    cnt++;
            }
            Console.WriteLine(cnt);
        }
    }
}
