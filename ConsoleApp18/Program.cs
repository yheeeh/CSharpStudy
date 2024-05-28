using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 참조 형식
 * 한 객체를 참조형 변수가 사용할 때 참조형에 의해 내용이 바뀌면 객체에 영향을 줌
 * class, interface, delegate, 배열, string
 * 객체와 참조형 사이의 대입은 객체의 메모리 주소가 복사됨
 */
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = { 1, 2, 3 };
            int[] RefArray; // 참조형 배열 변수
            RefArray = Array1;
            RefArray[1] = 20;
            Console.WriteLine("{0} {1} {2}", Array1[0], Array1[1], Array1[2]);
        }
    }
}
