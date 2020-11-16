using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess the secret number.");
            int userGuess;
            Random random=new Random();
            int secretNumber=random.Next(1,100);
            int usersCurrentUses=0;
            for(int i=4; i>0; i--){
                System.Console.WriteLine($"you have guessed {usersCurrentUses} times.");
                System.Console.WriteLine($"you have {i} guesses left.");
                System.Console.WriteLine("Type the number now:");
                usersCurrentUses++;
            userGuess=Int32.Parse(Console.ReadLine());
            if(userGuess==secretNumber){
                System.Console.WriteLine("You guessed correctly.");
                break;
            }
            else if(userGuess>secretNumber){
                System.Console.WriteLine("your guess was too high.");
            }
            else{
                System.Console.WriteLine("your guess was too low.");
            }
            };
        }
    }
}
