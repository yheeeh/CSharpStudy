using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 배열의 메서드
namespace Array6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array.Clear -> 배열 초기화
            // Array.Clear(배열, 시작 인덱스, 초기화할 개수(길이))
            int[] Array1 = { 1, 2, 3, 4, 5 };
            Array.Clear(Array1, 2, 3);
            foreach (int i in Array1) 
                Console.Write(i);
            Console.WriteLine();

            Array.Clear(Array1, 0, Array1.Length);
            foreach (int i in Array1)
                Console.Write(i);
            Console.WriteLine();

            // .Clone -> 배열 복사
            int[] Array2 = { 1,2,3,4 };
            int[] CloneArray = (int[]) Array2.Clone();

            CloneArray[2] = 30;
            foreach (int i in Array2)
                Console.Write(i);
            Console.WriteLine();

            foreach (int i in CloneArray)
                Console.Write(i);
            Console.WriteLine();

            string[] Days = { "일", "월", "화", "수", "목", "금", "토" };
            string[] DaysClone = (string[]) Days.Clone();
            foreach (string day in DaysClone)
                Console.Write(day);
            Console.WriteLine();
        }
    }
}
