using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// short 형의 유효 범위 값을 출력
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0} ~ {1}", short.MinValue, short.MaxValue);
        }
    }
}
