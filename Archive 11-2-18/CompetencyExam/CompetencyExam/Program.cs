using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetencyExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = 0;

            do
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("** Enter the number cooresponding to the action you want to make.");
                Console.WriteLine("** 1. Conditionals");
                Console.WriteLine("** 2. For Loops");
                Console.WriteLine("** 3. While Loops");
                Console.WriteLine("** 4. Arrays");
                Console.WriteLine("** 5. Lists");
                Console.WriteLine("** -1. End the program.");
                Console.WriteLine("***********************************************");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        int gradeLevel = 0;
                        int readingLevel = 0;
                        Console.Write("Enter your grade: ");
                        gradeLevel = int.Parse(Console.ReadLine());
                        Console.Write("Enter your reading grade level: ");
                        readingLevel = int.Parse(Console.ReadLine());
 
                        if (gradeLevel >= 9 && readingLevel >= gradeLevel)
                        {
                            Console.WriteLine("You are in high school and you read at an appropriate level.");
                        }
                        else if (gradeLevel >= 6 && readingLevel >= gradeLevel)
                        {
                            Console.WriteLine("You are in middle school and you read at an appropriate level.");
                        }
                        else if (gradeLevel < 6 && readingLevel >= gradeLevel)
                        {
                            Console.WriteLine("You are in elementary school and you read at an appropriate level.");
                        }
                        else
                        {
                            Console.WriteLine("You don't read at an appropriate level. Go Study.");
                        }
                        break;
                    case 2:
                        Console.Write("Enter a number to count by: ");
                        int countBy = int.Parse(Console.ReadLine());
                        Console.Write("Enter a number to count up to by " + countBy + ": ");
                        int countTo = int.Parse(Console.ReadLine());

                        for(int i = 0; i <= countTo; i += countBy)
                        {
                            Console.WriteLine(i);
                        }
                        break;
                    case 3:
                        int sum = 0;
                        Console.WriteLine("Our sum starts at 0. Enter integer values to add to, and print the sum. Enter 0 to stop adding.");
                        int sInput = 0;
                        do
                        {
                            Console.Write("Enter a value: ");
                            sInput = int.Parse(Console.ReadLine());
                            sum += sInput;
                            Console.WriteLine("New sum = " + sum);
                        } while (sInput != 0);
                        Console.WriteLine("Exiting loop, your final sum = " + sum);
                        break;
                    case 4:
                        int[] myArray = new int[10];
                        Console.WriteLine("You have an array of size 10 and of type int. Enter values to populate the array.");
                        for (int i = 0; i < myArray.Length; i++)
                        {
                            myArray[i] = int.Parse(Console.ReadLine());
                            Console.WriteLine(myArray[i] + " successfully added");
                        }
                        Console.WriteLine("All array values added. Here they are!");

                        for (int i = 0; i < myArray.Length; i++)
                        {
                            Console.WriteLine("index " + i + " = " + myArray[i]);
                        }
                        break;
                    case 5:
                        List<string> myList = new List<string>();
                        Console.WriteLine("You have a list of type string. Enter values to add to the list.");
                        Console.WriteLine("Type end to stop adding and to print out your list.");
                        string stringInput = "";
                        do
                        {
                            Console.Write("Enter a string: ");
                            stringInput = Console.ReadLine();
                            if (stringInput != "end")
                            {
                                myList.Add(stringInput);
                            }
                        } while (stringInput != "end");

                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.WriteLine("index " + i + " = " + myList[i]);
                        }
                        break;
                    case -1:
                        Console.WriteLine("You have chosen to close the program.");
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine();
            } while (input > 0);
        }
    }
}
