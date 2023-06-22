using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04
{
    class List2
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("aaa");
            list.Add("bbb");
            list.Add("ccc");
            Console.WriteLine(string.Join(" ", list));
            list.Insert(1, "ccc");
            Console.WriteLine(string.Join(" ", list));
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
            list.Reverse();
            Console.WriteLine(string.Join(" ", list));

            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict.Add("01", "aaa");
            dict.Add("02", "bbb");
            dict.Add("03", "bbb");

            dict["04"] = "ddd";
            dict["02"] = "www";

            //foreach(KeyValuePair<string,string> e in dict)
            foreach (var e in dict)
            {
                Console.WriteLine($"key: {e.Key}, value: {e.Value}");
            }
        }
    }
}
