using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day09
{
    class Quiz
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //1. 사용자에게 Email을 입력받고 유효한 형식인지 아닌지 출력하시오.
                //   정규표현식 사용하지 않고 메서드를 이용한다.
                //   @앞에 문자가 1개 이상이 있어야 하고
                //   .앞에 문자가 1개 이상이 있어야 한다.
                //Quiz1_1();

                //2. 주민등록번호를 입력받고, 출생년월일과 성별을 출력하시오.
                //Quiz2();

                //3. 사용자가 파일을 업로드했을때, 업로드한 파일의 파일명을 출력하고,
                //    확장자가 exe 파일인 경우 업로드 불가 메세지를 출력하시오.
                //    예) C:\Users\GDC 10\Pictures\PBY.jfif
                //Quiz3();

                //4. 주문번호가 오늘의 15번째인 경우에 적합한 주문번호를 출력하시오.
                //    예) 2023062900015
                //Quiz4();

                //5. 신규비밀번호를 위해서 난수(영문대문자 + 숫자) 8자리를 생성하여 출력하시오.
                Quiz5();
            }
        }

        private static void Quiz5()
        {
            //숫자       (0 ~ 9)
            //영어대문자 (10 ~ 35)  (65 ~   난수에 55를 더해서 문자로 변환
            //영어소문자 (36 ~ 61)  (97 ~   난수에 61을 더해서 문자로 변환
            Random rnd = new Random();
            StringBuilder sb = new StringBuilder();

            for(int i=0; i<8; i++)
            {
                int temp = rnd.Next(0, 62);
                if (temp < 10)
                    sb.Append(temp);
                else if (temp < 36)
                    sb.Append((char)(temp + 55));
                else
                    sb.Append((char)(temp + 61));
            }

            Console.WriteLine("신규 비밀번호 :" + sb.ToString());
            System.Threading.Thread.Sleep(1000);
        }

        private static void Quiz4()
        {
            //2023062900015
            string today = DateTime.Now.ToString("yyyyMMdd"); //20230629
            string orderNo = string.Concat(today, "15".PadLeft(5, '0'));
            Console.WriteLine("신규주문번호 :" + orderNo);
        }

        private static void Quiz3()
        {
            Console.Write("파일업로드 경로 : ");
            string upload = Console.ReadLine(); //C:\Users\GDC 10\Pictures\PBY.jfif
            int idx = upload.LastIndexOf("\\") + 1;
            string fileName = upload.Substring(idx);
            string ext = fileName.Substring(fileName.LastIndexOf(".") + 1);

            if (ext.Equals("exe", StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("해당 파일은 업로드 할 수 없습니다.");
            else
                Console.WriteLine($"업로드 파일정보 : 파일명:{fileName}  확장자{ext}");
        }

        private static void Quiz2()
        {
            Console.Write("주민등록번호 : "); 
            string jumin = Console.ReadLine(); //990926-2123456   9909262123456 
            jumin = jumin.Replace("-", "");    //9909262123456 

            if (jumin.Length != 13)
            {
                Console.WriteLine("유효한 주민등록번호가 아닙니다.");
                return;
            }

            string year = "19";
            string temp = jumin.Substring(6, 1);
            if (temp == "3" || temp == "4" || temp == "7" || temp == "8")
                year = "20";

            year = year + jumin.Substring(0, 2);
            string month = jumin.Substring(2, 2);
            string day = jumin.Substring(4, 2);

            string gender = (int.Parse(temp) % 2 == 1) ? "남" : "여";

            Console.WriteLine($"{year}년 {month}월 {day}일 성별:{gender}");
        }

        private static void Quiz1()
        {
            Console.Write("Email : ");
            string email = Console.ReadLine(); // f@F.c

            bool isValid = true;
            if (!email.Contains("@"))
                isValid = false;
            else if (email.IndexOf("@") < 1)
                isValid = false;
            else if (email.Substring(email.IndexOf("@") + 1).IndexOf(".") < 1)
                //email.IndexOf("@") + 1   @뒤를 
                //email.Substring(email.IndexOf("@") + 1)   @뒤부터 끝까지 문자열자르기
                isValid = false;

            if (!isValid)
            {
                Console.WriteLine("유효한 이메일이 아닙니다.");
            }
        }

        private static void Quiz1_1()
        {
            string pattern = @"^[a-zA-Z0-9+-\\_.]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";

            Console.Write("Email : ");
            string email = Console.ReadLine(); // f@F.c

            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(email);

            if (!isValid)
            {
                Console.WriteLine("유효한 이메일이 아닙니다.");
            }
        }
    }
}
