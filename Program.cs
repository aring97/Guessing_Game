using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number.");
            System.Console.WriteLine("Type the number now:");
            int userGuess;
            int secretNumber=42;
            for(int i=3; i>=0; i--){
            userGuess=Int32.Parse(Console.ReadLine());
            if(userGuess==secretNumber){
                System.Console.WriteLine("You guessed correctly.");
            }
            else{
                System.Console.WriteLine("you guessed incorrectly.");
            }
            };
        }
    }
}
