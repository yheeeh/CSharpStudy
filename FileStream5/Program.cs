using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 구조체를 이진 파일로 쓰고 읽기
namespace FileStream5
{
    struct Data
    {
        public int var1;
        public float var2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Data[] DataArray = new Data[2];

            DataArray[0].var1 = 15;
            DataArray[0].var2 = 2.07f;

            DataArray[1].var1 = 100;
            DataArray[1].var2 = 3.15f;

            BinaryWriter bw = new BinaryWriter(File.Open("test.txt", FileMode.Create));
            for (int i = 0; i < DataArray.Length; i++)
            {
                bw.Write(DataArray[i].var1);
                bw.Write(DataArray[i].var2);
            }

            bw.Close();

            int var1;
            float var2;

            BinaryReader br = new BinaryReader(File.Open("test.txt", FileMode.Open));
            while (true)
            {
                try
                {
                    var1 = br.ReadInt32();
                    var2 = br.ReadSingle();
                    Console.WriteLine("{0} {1}", var1, var2);
                }
                catch (EndOfStreamException e) // 파일 끝에 도달한 예외
                {
                    br.Close();
                    break;
                }
            }
        }
    }
}
