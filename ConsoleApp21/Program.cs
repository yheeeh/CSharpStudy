using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* null 병합 연산자
 * C = A ?? B
 * A가 null이 아니면 A를 C에 대입
 * A가 null이면 B를 C에 대입
 */
namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? x = null; // nullable 형식, null 저장 가능
            int y = x ?? -1;
            Console.WriteLine(y);
            x = 10;
            y = x ?? -1;
            Console.WriteLine(y);
        }
    }
}
