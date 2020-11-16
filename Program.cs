using System;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please select a difficulty: Easy, Medium, Hard");
            string difficulty=Console.ReadLine();
            int i=0;
            bool cheater=false;
            if(difficulty.ToLower()=="hard"){
                i=4;
            }
            else if(difficulty.ToLower()=="medium"){
                i=6;
            }
            else if(difficulty.ToLower()=="cheater"){
                cheater=true;
            }
            else{
                i=8;
            }
            Console.WriteLine("Guess the secret number.");
            int userGuess;
            Random random=new Random();
            int secretNumber=random.Next(1,100);
            int usersCurrentUses=0;
            if(cheater){
                while(cheater){
                    System.Console.WriteLine($"you have guessed {usersCurrentUses} times.");
                    System.Console.WriteLine($"you have ?????? guesses left.");
                    System.Console.WriteLine("Type the number now:");
                    usersCurrentUses++;
                    userGuess=Int32.Parse(Console.ReadLine());
                    if(userGuess==secretNumber){
                        System.Console.WriteLine("You guessed correctly.");
                        cheater=false;
                    }
                    else if(userGuess>secretNumber){
                        System.Console.WriteLine("your guess was too high.");
                    }
                    else{
                        System.Console.WriteLine("your guess was too low.");
                    }
                }
            }else{
            for(; i>0; i--){
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
            };
        }
    }
}
