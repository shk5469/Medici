using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    class EnumTest
    {
        public enum MyChannel { SBS, KBS, MBC, TVN, EBS, JTBC }
        static void Main(string[] args)
        {
            MyChannel ch1 = MyChannel.TVN;

            Console.WriteLine(ch1);
            Console.WriteLine((int)ch1);
        }
    }

    class MyEnumTest
    {
        static void Main(string[] args)
        {
            EnumTest.MyChannel ch1 = EnumTest.MyChannel.TVN;
            var ch2 = ch1;
        }
    }
}