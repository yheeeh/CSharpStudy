using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
// 인덱스: 클래스 내의 배열 또는 컬렉션을 외부에서 접근할 수 있게 해줌
// 배열과 같이 사용
// 형식
// public 데이터형 this[int index] { set{ } get{ } }
// 속성 + 배열 = 인덱서
namespace Indexer
{
    class A
    {
        private int[] number = new int[5];
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }

    class B
    {
        ArrayList List = new ArrayList(); // 접근한정자 생략 == private
        public string this[int index]
        {
            get
            {
                if (index >= 0 && index < List.Count)
                    return (string)List[index];
                else
                    return null;
            }

            set
            {
                if (index >= 0 && index < List.Count)
                    List[index] = value;
                else if (index == List.Count)
                    List.Add(value);
            }

        }

        public void Print()
        {
            foreach(string m in List)
            {
                Console.WriteLine(m);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            for (int i = 0; i < 5; i++)
            {
                a[i] = i;
                Console.WriteLine(a[i]);
            }

            Console.WriteLine();

            B b = new B();
            b[0] = "A";
            b[1] = "B";
            b[2] = "C";
            b[3] = "D";

            b.Print();
            b[1] = "Hello World!";
            b.Print();
        }
    }
}
