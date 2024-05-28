using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public struct MyStruct
    {
        public int Kor, Eng, Math, Total;
        public float Average;

        public void Compute()
        {
            Total = Kor + Eng + Math;
            Average = Total / 3.0f;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStruct myStruct = new MyStruct();
            myStruct.Kor = 80;
            myStruct.Eng = 90;
            myStruct.Math = 86;
            myStruct.Compute();
            Console.WriteLine("총점: {0} 평균: {1}", myStruct.Total, myStruct.Average);
        }
    }
}
