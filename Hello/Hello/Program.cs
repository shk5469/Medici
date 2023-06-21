using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            float weight, height, bmi;
            int stateNumber;
            string[] msg, stateName = { "저체중", "정상", "과체중", "경도비만", "중등도비만" };

            Console.Write("몸무게(kg)와 키(cm)를 입력해주세요(ex. 73,170): ");
            msg = Console.ReadLine().Split(',');
            weight = float.Parse(msg[0]);
            height = float.Parse(msg[1]) / 100;
            bmi = weight / (height * height);

            if (bmi <= 18.5)
                stateNumber = 0;
            else if (bmi < 23)
                stateNumber = 1;
            else if (bmi < 25)
                stateNumber = 2;
            else if (bmi < 30)
                stateNumber = 3;
            else
                stateNumber = 4;

            //Console.WriteLine("당신의 BMI지수는 {0:F2}입니다.", bmi);
            Console.WriteLine($"당신의 BMI지수는 {bmi:f2}이고 {stateName[stateNumber]}입니다.");
        }
    }
}
