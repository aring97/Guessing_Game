using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number");
            System.Console.WriteLine("Type the number now:");
            int userGuess=Int32.Parse(Console.ReadLine());
            System.Console.WriteLine($"Your guess was {userGuess}");
        }
    }
}
