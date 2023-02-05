using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double startingBalance = 100.00;
            double playerBalance = startingBalance;
            string playerName;
            
           
            
            Console.Title = "BlackJack ♠♥♦♣";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to Kennie's and Ludwig's Casino");
            Console.WriteLine("What is your name dear gambler?");
            playerName = Console.ReadLine();
            Console.WriteLine("\nHello " + playerName);
            Console.WriteLine($"Your current balance is {playerBalance}");
            Console.WriteLine("Press 1 to start a new game");
            Console.WriteLine("Press 2 reset stats");
            Console.WriteLine("Press 3 to exit");


            Console.WriteLine("\nPlease type in menu option number and press <Enter>");
            string menuOption = Console.ReadLine();

            switch(menuOption)
            {
                case "1":

                    Console.WriteLine("Shuffling the cards..");
                    Console.WriteLine("Dealing cards..");

                    var randomGenerator = new Random();
                    var firstCardScore = randomGenerator.Next(1, 10);
                    var secondCardScore = randomGenerator.Next(1, 10);
                    var thirdCardScore = 0;
                    

                    Console.WriteLine($"Your first card is: {firstCardScore}");
                    Console.WriteLine($"Your first card is: {secondCardScore}");
                    Console.WriteLine($"Would you like to be dealt another card?\n1. Yes 2. No");
                    var dealAnotherCard = Console.ReadLine();
                    if(dealAnotherCard == "1")
                    {
                        thirdCardScore = randomGenerator.Next(1, 10);
                        Console.WriteLine($"Your third card is: {thirdCardScore}");
                    }

                    var totalCardScore = firstCardScore + secondCardScore + thirdCardScore;
                    Console.WriteLine($"Total card score: {totalCardScore}");

                    if(totalCardScore > 21)
                    {
                        Console.WriteLine("Your total is over 21 and you have lost..\nPress any key to exit");
                        Console.ReadKey();
                        return;
                    }

                    var dealerCards = randomGenerator.Next(10, 21);

                    Console.WriteLine($"Dealers total card score is: {dealerCards}");

                    if (totalCardScore <= dealerCards)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your total is lower than the dealers and you have lost..\nPress any key to exit");
                        Console.ReadKey();
                        return;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Congratulations you have won!!\nPress any key to exit");
                    Console.ReadKey();
                    return;

                    
                    case "2":
                    Console.WriteLine("Are you sure you want to reset your stats?\n1. Yes\n2. No");
                    string answer = Console.ReadLine();
                    if(answer == "1")
                    {
                        playerBalance = startingBalance;
                    }
                   

                    break;

                    case "3":
                    Console.WriteLine("Exiting BlackJack");
                    return;
                    
            }
            Console.ReadKey();
            
        }
    }
}
