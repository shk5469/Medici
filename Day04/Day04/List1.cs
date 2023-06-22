using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class List1
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("김밥");
            list.Add("떡라면");
            list.Add("된장국");
            list.Add("쫄면");
            list.Add("김밥");

            for (int i = 0; i > list.Count(); i++)
                Console.WriteLine(list[i]);

            HashSet<string> set = new HashSet<string>();

            set.Add("김밥");
            set.Add("떡라면");
            set.Add("된장국");
            set.Add("쫄면");
            set.Add("김밥");

            foreach (string e in set)
                Console.WriteLine(e);
        }
    }
}
