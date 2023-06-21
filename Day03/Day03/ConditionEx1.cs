using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
{
    class ConditionEx1
    {
        static void Main(string[] args)
        {
            Console.Write("점수를 입력하세요.: ");
            int score = int.Parse(Console.ReadLine());
            string grade, result= "불합격";
            if (score >= 80)
            {
                if (score >= 90)                
                    grade = "A";
                else
                    grade = "B";
                result = "합격";
            }
            else if(score >= 70)
                grade = "C";
            else if (score >= 60)
                grade = "D";
            else
                grade = "F";
            Console.WriteLine($"학점은 {grade}이고 {result}입니다.");
        }
    }
}
