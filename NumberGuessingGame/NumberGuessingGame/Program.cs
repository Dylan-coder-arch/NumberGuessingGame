using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int numberToGuess = rand.Next(1, 101);
            Console.WriteLine("Hello! Welcome! Please enter a number to guess!");
            int guess = 0;
            while (guess != numberToGuess)
            {

                guess = Convert.ToInt32(Console.ReadLine());

                if (guess < numberToGuess)
                {
                    Console.WriteLine("Please guess a little higher!!");
                } else if (guess > numberToGuess)
                {
                    Console.WriteLine("Please guess a little lower!");
                }


            }
            Console.WriteLine("Congratulations you guessed correctly!");
            Console.Read();
        }
    }
}
