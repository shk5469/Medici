using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class AvgEx1
    {
        static void Main(string[] args)
        {
            int kor = 78;
            int eng = 90;
            int math = 89;

            int tot = kor + eng + math;
            Console.WriteLine($"총점은 {tot}점이고, 평균은 {tot/3.0}점 입니다.");
        }
    }
}
