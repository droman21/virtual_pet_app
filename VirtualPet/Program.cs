using Microsoft.VisualBasic;
using System;
using System.Transactions;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Hello and Welcome to Dan's Pet Shop!\n");
                Console.WriteLine("Which task would you like to perform?");
                Console.WriteLine("1. Pick a Pet");
                Console.WriteLine("2. Name My Pet");
                Console.WriteLine("3. Feed My Pet");
                Console.WriteLine("4. Check Status of My Pet");
                Console.WriteLine("5. Take Pet to Doctor");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        //PickaPet();
                        break;
                    case "2":
                      //  NamePet();
                        break;
                    case "3":
                      //  FeedPet();
                        break;
                    case "4":
                      //  CheckStatus();
                        break;
                    case "5":
                    // VisitDoc();
                    case "d":
                        keepThinking = false;
                        Console.WriteLine("Good Bye! Thanks for Visiting!");
                        break;
                    default:
                        break;


                }
            }

        }
    }
}
