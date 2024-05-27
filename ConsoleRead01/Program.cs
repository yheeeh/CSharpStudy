using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 사용자가 누른 키를 화면에 출력하되 Escape 키가 입력되면 프로그램 종료
namespace ConsoleRead01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.A) // 대소문자 구별을 안 함
                    Console.WriteLine(" a가 눌렸다"); 
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
