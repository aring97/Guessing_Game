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
            int secretNumber=42;
            if(userGuess==secretNumber){
                System.Console.WriteLine("You guessed correctly. you win");
            }
            else{
                System.Console.WriteLine("you guessed incorrectly. you lose");
            }
        }
    }
}
