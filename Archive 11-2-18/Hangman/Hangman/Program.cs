using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of words to select from. 
            //Create a Random object
            //Create a string to hold our randomly selected from the array word.
            //Create a list of characters to hold our guesses
            //Create a boolean to test whether or not our solution is currently correct.
            //Create a counter to count the number of failed guesses.

            //do-while failed guesses < 6 and sollution is not correct
                //Print out the hidden version of our string. If we print a single "_" then our solution is currently not correct.
                //if our solution is currently not correct then
                    //Print to the user the guesses
                    //Ask the user for input
                    //if list of guesses does not contain the input then
                        //Add input to list of guesses
                        //if random word does not contain input then
                            //increment failed guesses counter
            //end do-while

            //Print out to the user the results of the game


            //Create an array of words to select from. 
            string[] words = new string[] { "hello", "goodby" };
            //Create a Random object
            Random rand = new Random();
            //Create a string to hold our randomly selected from the array word.
            string curWord = words[rand.Next(0, words.Length)];
            //Create a list of characters to hold our guesses
            List<char> guesses = new List<char>();
            //Create a boolean to test whether or not our solution is currently correct.
            bool isCorrect = false;
            //Create a counter to count the number of failed guesses.
            int failedGuesses = 0;

            //do-while failed guesses < 6 and sollution is not correct
            do
            {
                //Print out the hidden version of our string. If we print a single "_" then our solution is currently not correct.
                isCorrect = true;
                for (int i = 0; i < curWord.Length; i++)
                {
                    if (guesses.Contains(curWord[i]))
                    {
                        Console.Write(curWord[i] + " ");
                    }
                    else
                    {
                        Console.Write("_ ");
                        isCorrect = false;
                    }
                }

                //if our solution is currently not correct then
                if (isCorrect == false)
                {
                    //Print to the user the guesses
                    Console.WriteLine();
                    Console.WriteLine((6 - failedGuesses) + " incorrect guesses left");
                    Console.Write("You have guessed the following: ");
                    foreach (char c in guesses)
                    {
                        Console.Write(c + " ");
                    }
                    Console.WriteLine();

                    //Ask the user for input
                    Console.WriteLine("Enter the character you want to guess: ");
                    char input = char.Parse(Console.ReadLine());

                    //if list of guesses does not contain the input then
                    if (!guesses.Contains(input))
                    {
                        //Add input to list of guesses
                        guesses.Add(input);
                        //if random word does not contain input then
                        if (!curWord.Contains(input))
                        {
                            //increment failed guesses counter
                            failedGuesses++;
                        }
                    }

                }
                Console.WriteLine();
                Console.WriteLine();
                //end do-while
            } while (failedGuesses < 6 && isCorrect == false);

            //Print out to the user the results of the game
            if (isCorrect)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }
            Console.ReadKey();
        }
    }
}