using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class BMITest
    {
        static void Main()
        {
            float weight, height, bmi;
            int stateNumber;
            string[] msg, stateName = { "저체중", "정상", "과체중", "비만" };

            Console.Write("몸무게(kg)와 키(cm)를 입력해주세요(ex. 73,170): ");
            msg = Console.ReadLine().Split(',');

            try
            {
                weight = float.Parse(msg[0]);
                height = float.Parse(msg[1]) / 100;
                bmi = weight / (height * height);

                stateNumber = CalcBmi(weight, height);
                //Console.WriteLine("당신의 BMI지수는 {0:F2}입니다.", bmi);
                Console.WriteLine($"당신의 BMI지수는 {bmi:f2}이고 {stateName[stateNumber]}입니다.");
            }
            catch
            {
                Console.WriteLine("값을 잘못 입력했습니다.");
            }
        }

        static int CalcBmi(float weight, float height)
        {
            float bmi = weight / (height * height);

            if (bmi < 20)
                return 0;
            else if (bmi < 25)
                return 1;
            else if (bmi < 30)
                return 2;
            else
                return 3;
        }
    }
}
