using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 가변 배열
            int[][] array = new int[2][];
            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[2] { 4, 5 };

            for (int i = 0; i < array.Length; i++) 
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write(array[i][j]);
            Console.WriteLine();


            int[][][] array2 = new int[2][][];
            array2[0] = new int[2][];
            array2[1] = new int[3][];

            array2[0][0] = new int[3] { 1, 2, 3 };
            array2[0][1] = new int[2] { 4, 5 };

            array2[1][0] = new int[3] { 6, 7, 8 };
            array2[1][1] = new int[2] { 9, 10 };
            array2[1][2] = new int[2] { 11, 12 };

            for (int i = 0;i < array2.Length;i++)
                for (int j = 0; j < array2[i].Length;j++)
                    for (int k = 0;k < array2[i][j].Length;k++)
                        Console.Write("{0} ", array2[i][j][k]);
        }
    }
}
