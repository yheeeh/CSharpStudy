using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nArray = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 5; i++)
            {
                Console.Write("{0} ", nArray[i]);
            }
            Console.Write('\n');

            for (int i = 0;i < nArray.Length; i++) {
                Console.Write("{0} ", nArray[i]);
             }
            Console.WriteLine();

            foreach (int i in nArray)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            foreach (string day in Days)
            {
                Console.Write(day + " ");
            }
        }
    }
}
