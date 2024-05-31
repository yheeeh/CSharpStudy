using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 제어문
namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // switch case
            // C#의 switch문은 모든 case에 반드시 break문이 들어가야 함
            int nNum = 1;
            switch (nNum)
            {
                case 1:
                    Console.WriteLine("1입니다");
                    break;
                case 2:
                    Console.WriteLine("2입니다");
                    break;
            }

            // foreach
            int[] Array1 = { 1, 2, 3, 4, 5 };
            foreach(int i in Array1)
            {
                Console.WriteLine(i);
            }

            ArrayList List = new ArrayList();
            List.Add(1);
            List.Add(2);
            List.Add(3);

            foreach(int i in List)
            {
                Console.WriteLine(i);
            }
        }
    }
}
