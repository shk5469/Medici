using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    class DateTimeEx1
    {
        static void Main(string[] args)
        {
            double k = 34345345.1;
            Console.WriteLine(k.ToString("#,###.00"));

            //오늘 날짜
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss,fff"));
            Console.WriteLine(DateTime.Now.ToShortDateString()); //yyyy-MM-dd

            //특정일을 기준으로 DateTime 생성
            DateTime dt1 = new DateTime(1999, 9, 26);
            TimeSpan diff = DateTime.Now - dt1; // TimeSpan = DateTime - DateTime
            Console.WriteLine((int)diff.TotalDays);

            //11월 10일은 몇일 남았을까요?
            DateTime dt2 = new DateTime(2023, 11, 10);
            diff = dt2 - DateTime.Now;
            Console.WriteLine((int)diff.TotalDays);

            //일주일 전의 날짜
            DateTime dt3 = DateTime.Now.AddDays(-7);
            Console.WriteLine(dt3.ToString("yyyy-MM-dd"));

            //조회기간 (월별)
            DateTime dtStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime dtEnd = dtStart.AddMonths(1).AddDays(-1);

            Console.WriteLine($"{dtStart.ToString("yyyy-MM-dd")}  ~  {dtEnd.ToString("yyyy-MM-dd")}");
        }
    }
}
