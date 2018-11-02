using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[,] board = new char[3, 3];
            //for(int i = 0; i < board.GetLength(0); i++)
            //{
            //    for (int j = 0; j < board.GetLength(1); j++)
            //    {
            //        board[i, j] = ' ';
            //    }
            //}

            //List<string> strings = new List<string>();
            //for (int a = 65; a <= 90; a++)
            //{
            //    for (int b = 65; b <= 90; b++)
            //    {
            //        for (int c = 65; c <= 90; c++)
            //        {
            //            for (int d = 65; d <= 90; d++)
            //            {
            //                for (int e = 65; e <= 90; e++)
            //                {
            //                    for (int f = 65; f <= 90; f++)
            //                    {
            //                        for (int g = 65; g <= 90; g++)
            //                        {
            //                            for (int h = 65; h <= 90; h++)
            //                            {
            //                                for (int i = 65; i <= 90; i++)
            //                                {
            //                                    for (int j = 65; j <= 90; j++)
            //                                    {
            //                                        for (int k = 65; k <= 90; k++)
            //                                        {
            //                                            for (int l = 65; l <= 90; l++)
            //                                            {
            //                                                string s = "";
            //                                                s += (char)a;
            //                                                s += (char)b;
            //                                                s += (char)c;
            //                                                s += (char)d;
            //                                                s += (char)e;
            //                                                s += (char)f;
            //                                                s += (char)g;
            //                                                s += (char)h;
            //                                                s += (char)i;
            //                                                s += (char)j;
            //                                                s += (char)k;
            //                                                s += (char)l;
            //                                                strings.Add(s);
            //                                                Console.WriteLine(strings[strings.Count - 1]);
            //                                            }
            //                                        }
            //                                    }
            //                                }
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}


            //int[,] multiDimensionalArray = new int[10, 5];
            //for (int i = 0; i < multiDimensionalArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < multiDimensionalArray.GetLength(1); j++)
            //    {
            //        multiDimensionalArray[i, j] = i * j;
            //    }
            //}
            //Print2DArray(multiDimensionalArray);



            int[][] jaggedArray = new int[10][];
            for (int i = 0; i < jaggedArray.GetLength(0); i++)
            {
                jaggedArray[i] = new int[i + 1];
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    jaggedArray[i][j] = i * j;
                }
            }
            Print2DJaggedArray(jaggedArray);

            //List<List<string>> twoDeeList = new List<List<string>>();
            //twoDeeList.Add(new List<string>());
            //twoDeeList[0].Add("Hello");
        }

        static void Print2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write((array[i, j].ToString().Length == 1 ? " " : "") + array[i, j] + " |");
                }
                Console.WriteLine();
            }
        }

        static void Print2DJaggedArray(int[][] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("| ");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write((array[i][j].ToString().Length == 1 ? " " : "") + array[i][j] + " |");
                }
                Console.WriteLine();
            }
        }
    }
}
