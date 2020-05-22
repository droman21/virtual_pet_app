using Microsoft.VisualBasic;
using System;
using System.Transactions;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet newPet = new Pet();
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("Hello and Welcome to Dan's Pet Shop!\n");
                Console.WriteLine("Which task would you like to perform?");
                //Console.WriteLine("1. Pick a Pet");
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
                        Console.WriteLine("Please enter your pet's name");
                        string petName = Console.ReadLine();
                        newPet.SetName(petName);
                        break;
                    case "3":
                        //  FeedPet();
                        Console.WriteLine("Your pet is hunger. Feed it!");
                        string feedPet = Console.ReadLine();
                        break;
                    case "4":
                        //  CheckStatus();
                        Console.WriteLine("How is my pet doing?");
                        
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
