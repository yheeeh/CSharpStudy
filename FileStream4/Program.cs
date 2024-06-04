using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 이진 파일 쓰기
            using (BinaryWriter bw = new BinaryWriter(new FileStream("test.dat", FileMode.Create)))
            {
                bw.Write(12);
                bw.Write(3.14f);
                bw.Write("Hello World!");
            }

            // 이진 파일 읽기
            int var1;
            float var2;
            string str;

            using (BinaryReader br = new BinaryReader(File.Open("test.dat", FileMode.Open)))
            {
                var1 = br.ReadInt32();
                var2 = br.ReadSingle();
                str = br.ReadString();
            }

            Console.WriteLine("{0} {1} {2}", var1, var2, str);
        }
    }
}
