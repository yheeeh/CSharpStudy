using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 사용자가 누른 키를 출력
namespace ConsoleReadLine01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.ReadKey -> 한 문자만 입력받음

            ConsoleKeyInfo keyInfo;
            do
            {
                keyInfo = Console.ReadKey(true);// 이렇게만 쓰면 입력한 글자가 출력이 안 됨(false로 하면 출력됨)
                if (keyInfo.KeyChar == 'a')
                    Console.WriteLine("a가 눌렸다");
                Console.Write(keyInfo.KeyChar);
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
