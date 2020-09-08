using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class FlowControl
    {
        public const int minimumAge = 13;
        public static int playerAge;
        public static string permission;
        public static int computerRPSRandomNum;

        public static void FCIfElse()
        {
            FCSwitchRoll();
            Console.WriteLine("Welcome to Rock Paper Scissors, what is your age?");
            playerAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You inputted {playerAge}.");

            if (playerAge >= minimumAge)
            {
                //f true run this block of code
                Console.WriteLine("Excellent. You are old enough to get started.");
                //Add method
            }
            else
            {
                //if not true run this block of code
                Console.WriteLine($"Ouch. Sorry little lad. You must at least {minimumAge} to play. Try again whe you are older or ask your parents for permission.");
                //Add New Method
                FCElseIf();

            }
        }
        public static void FCElseIf()
        {
            Console.WriteLine("Do you have your parents permission to play?");
            permission = Console.ReadLine().ToLower();
            if (permission == "Yes" || permission == "y")
            {
                //run a block of code
                Console.WriteLine("Great. Let's get started.");
                Console.ReadLine();
                //Input method here to start game.
            }
            else if (permission == "no" || permission == "n")
            {
                //run block of code
                Console.WriteLine("Well that's too bad. Try again when you are old enough. Press eneter to exit.");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("I did not understand that answer. Please Try Again!");
                FCElseIf();
            }
        }
        public static void FCSwitchRoll()
        {
            Random computerRandomRPS = new Random();
            computerRPSRandomNum = computerRandomRPS.Next(1, 4);
            Console.WriteLine($"PC Random Number is {computerRPSRandomNum}");
            
            switch(computerRPSRandomNum)
            {
                case 4:
                    Console.WriteLine("Oops PC rolled a 4. That wasn't suppose to happen.");
                    FCSwitchRoll();
                    break;
                case 3:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Rock.");
                    break;
                case 2:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Paper");
                    break;
                case 1:
                    Console.WriteLine($"PC chose a {computerRPSRandomNum}. That is equal to Scissor.");
                    break;
                    
                default:
                    Console.WriteLine($"Something unexpected happened. Roll again.");
                    FCSwitchRoll();
                    break;
            }

        }
    }
}
