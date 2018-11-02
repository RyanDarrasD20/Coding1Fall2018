using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Squares
            for (int i = 0; i < 1; i++)
            {
                Console.Write("X");
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            //Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }


            //triangles
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j < 4 - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 + i; j++)
                {
                    if (j < 2 - i)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

            //Specials
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (4 - i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (4 - i == j || i == j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("X");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
