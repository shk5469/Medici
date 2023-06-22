using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class Dictionary1
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            dict.Add("aaa", 89);
            dict.Add("bbb", 93);
            dict.Add("ccc", 78);

            dict["aaa"] = 75;
            int n = dict["bbb"];
            dict.Remove("ccc");

            if (dict.ContainsKey("ccc"))
                Console.WriteLine(dict["ccc"]);
            else
                Console.WriteLine("해당 키값이 없습니다.");
            dict.Clear();
            dict.Count();
        }
    }
}
