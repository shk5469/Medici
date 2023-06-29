using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class Program
    {
        static void Main(string[] args)
        {
            string stuID = "9145032";
            Console.WriteLine(stuID.Substring(0, 2));
            Console.WriteLine(stuID.Substring(2, 2));
            Console.WriteLine(stuID.Substring(4));
            //1부터 100까지의 수 중에서 15의 배수를 출력하시오.
            //string msg = string.Empty;

            //for(int i=1; i<=100; i++)
            //{
            //    if (i % 15 == 0)
            //        msg += i + ",";
            //}
            // "15, 30, 45, 60, 75, 90, "

            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                    sb.Append(i + ", ");
            }


            string msg = sb.ToString().TrimEnd(',',' ');
            Console.WriteLine(msg);

            //if (msg.EndsWith(", "))
            //{
            //    msg = msg.Substring(0, msg.Length - 2);
            //}
            Console.WriteLine(msg); //"15, 30, 45, 60, 75, 90"

            string temp = " 배열의 각 요소를      하나의 문자열로 합칠때 ";
            //의 => 에
            temp = temp.Replace("의", "에");
            Console.WriteLine(temp);

            Console.WriteLine(temp.Trim().Replace(" ", ""));
            Console.WriteLine(temp.Trim().Replace(" ", "").Length);

            int nextNo = 1953;
            string empno = nextNo.ToString().PadLeft(4, '0');
            Console.WriteLine(empno);


            List<string> menus = new List<string>{ "a", "b", "cc", "ddd", "eee" };

            //배열의 각 요소를 하나의 문자열로 합칠때
            string result = string.Join(",", menus);

            //result = "a,b,cc,ddd,eee"

            string[] sections = result.Split(',');
            //sections[0] ~ sections[4] = "a";

            string email = InputAnswer("Email");
            if (email.IndexOf("@") < 1)
                Console.WriteLine("유효한 이메일 형식이 아닙니다.");

            //if (! email.Contains("@"))
            //    Console.WriteLine("유효한 이메일 형식이 아닙니다.");


            string tel = "111-2222";
            Console.WriteLine("010" + tel);
            // + 연산자 (이항연산자, 같은 데이터타입만 더할 수 있다)
            // 문자열은 한쪽만 문자열이어도, 다른쪽이 자동으로 문자열로 변환되어 문자열연결이 된다.
            Console.WriteLine(3.14 + "aaa" + 10);
            Console.WriteLine(tel.Concat("aaa"));

            Person p1 = new Person("aaa");
            Person p2 = new Person("bbbb");

            int? k = null;
            string name = string.Empty;
            
            string addr = InputAnswer("주소");
            if (addr == null)
                Console.WriteLine("주소를 입력하세요.");
            else
                Console.WriteLine(addr);
        }

        //항목을 전달받아서 입력받은 문자열을 반환하는 메서드
        static string InputAnswer(string title)
        {
            Console.Write($"{title} :");
            string input = Console.ReadLine();

            //if (input == null || input.Trim().Length < 1)
            if (string.IsNullOrWhiteSpace(input))
                return null;
            else
                return input;
        }
    }
}
