using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1 + str2;
            string srt4 = "program" + "ming";
            Console.WriteLine("{0} {1}", str3, srt4);
            Console.WriteLine(str3[4]);

            if (str3 == "Hello World!")
            {
                Console.WriteLine("같음");
            }
            else
            {
                Console.WriteLine("다름");
            }

            Console.WriteLine("문자 개수: {0}", str3.Length);
        }
    }
}
