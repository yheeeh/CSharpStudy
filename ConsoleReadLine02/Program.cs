using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleReadLine02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadLine() -> 사용자가 엔터키를 누를 때까지 입력을 받음

            int Kor, Eng, Math, Total;
            float Average;

            Console.Write("국어 점수를 입력해주세요: ");
            Kor = Convert.ToInt32(Console.ReadLine());
            Console.Write("영어 점수를 입력해주세요: ");
            Eng = Convert.ToInt32(Console.ReadLine());
            Console.Write("수학 점수를 입력해주세요: ");
            Math = Convert.ToInt32(Console.ReadLine());
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
            Console.WriteLine("{0} {1} {2} 총점: {3} 평균: {4:f2}", Kor, Eng, Math, Total, Average);
        }
    }
}
