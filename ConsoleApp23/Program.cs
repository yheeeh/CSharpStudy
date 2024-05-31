using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3 };
            try
            {
                array[3] = 10;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("배열 인덱스 에러 발생");
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                array[2] = 10;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
