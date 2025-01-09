using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool IsGuess = false;

            Console.WriteLine("Welcome to Number Guessing Game!...");
            Console.WriteLine("I have selected a number between 1 and 100. Can you guess it?");

            while (!IsGuess)
            {
                Console.WriteLine("Enter your guess : ");
                int playerGuess;

                bool IsValid = int.TryParse(Console.ReadLine(), out playerGuess);

                if ( !IsValid || playerGuess < 1 || playerGuess > 100 )
                {
                    Console.WriteLine("Invalid input! Please enter a number between 1 and 100.");
                    continue;
                }

                attempts++;

                if (playerGuess == secretNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {secretNumber} in {attempts} attempts.");
                    IsGuess = true;
                } else if (playerGuess < secretNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                } else
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }

            Console.ReadKey();

        }
    }
}
