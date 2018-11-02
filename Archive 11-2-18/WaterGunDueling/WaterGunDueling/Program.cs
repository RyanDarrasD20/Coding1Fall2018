using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace WaterGunDueling
{
    class Program
    {
        static void Main(string[] args)
        {
            WaterGun player1 = new WaterGun();
            Thread.Sleep(20);
            WaterGun player2 = new WaterGun();

            int player1Input;
            int player2Input;

            float player1ShootAmount;
            float player2ShootAmount;

            do
            {
                Console.WriteLine("Player 1, what action would you like to take: ");
                player1Input = MenuAndUserInput();

                Console.WriteLine("Player 2, what action would you like to take: ");
                player2Input = MenuAndUserInput();

                if (player1Input == 1)
                {
                    Console.Write("Player 1, how much did you want to shoot: ");
                    player1ShootAmount = float.Parse(Console.ReadLine());
                    player2.IsWet = player1.Shoot(player1ShootAmount);
                }
                else if (player1Input == 2)
                {
                    player1.Refill();
                }

                if (player2Input == 1)
                {
                    Console.Write("Player 2, how much did you want to shoot: ");
                    player2ShootAmount = float.Parse(Console.ReadLine());
                    player1.IsWet = player2.Shoot(player2ShootAmount);
                }
                else if (player2Input == 2)
                {
                    player2.Refill();
                }

                if (player1.IsWet && player2.IsWet)
                {
                    Console.WriteLine("You both lose!");
                }
                else if (player1.IsWet)
                {
                    Console.WriteLine("Player 2 wins!");
                }
                else if (player2.IsWet)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Nobody is wet! Yet...");
                }
                Console.WriteLine();
            } while (player1.IsWet == false && player2.IsWet == false);
            Console.ReadLine();
        }

        static int MenuAndUserInput()
        {
            Console.WriteLine("1. Shoot at the opponent");
            Console.WriteLine("2. Refill your water gun");
            return int.Parse(Console.ReadLine());
        }
    }
}
