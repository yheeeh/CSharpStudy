using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array4
{
    internal class Program
    {
        static void TransArray(string[] array)
        {
            string[] HangulDays = { "일", "월", "화", "수", "목", "금", "토" };
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = HangulDays[i];
            }
        }
        static void Main(string[] args)
        {
            string[] Days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            TransArray(Days);
            foreach (string day in Days) 
                Console.Write(day);
            Console.WriteLine();
        }
    }
}
