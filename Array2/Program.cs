using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2차원 배열
            int[,] nArray1 = new int[2, 2];
            nArray1[0, 0] = 1;
            nArray1[0, 1] = 2;
            nArray1[1, 0] = 3;
            nArray1[1, 1] = 4;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(nArray1[i, j] + " ");
                }
                Console.Write('\n');
            }

            int[,] nArray2 = { { 1, 2 }, { 3, 4 } };
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    Console.Write(nArray1[i, j] + " ");
            Console.Write("\n");

            // 다차원 배열
            string[,,] strArray = { { { "ab", "cd" } , { "ef", "gh"} },
                { {"ij", "kl" }, {"mn", "op" } } };
            for (int i = 0;i < 2;i++)
                for (int j = 0; j < 2;j++)
                    for (int k = 0; k < 2;k++)
                        Console.Write(strArray[i, j, k] + " ");
        }
    }
}
