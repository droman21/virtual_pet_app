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
            Shelter petShelter = new Shelter();
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
                Console.WriteLine("6. Add Pet to Shelter");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        //PickaPet();
                        Console.WriteLine("Please enter the type of pet you'd like");
                        string petType = Console.ReadLine();
                        newPet.SetPetType(petType);
                        Console.WriteLine("Please enter your pet's name");
                        string petName = Console.ReadLine();
                        newPet.SetName(petName);
                        break;
                    case "2":
                        // NamedPet();
                        Console.WriteLine("Please enter your pet's name");
                        string petName = Console.ReadLine();
                        newPet.SetName(petName);
                        break;
                    case "3":
                        //FedPet();
                        Console.WriteLine("Your pet is hunger. Feed it!");
                        string feedPet = Console.ReadLine();
                        
                        break;
                    case "4":
                        //  CheckStatus();
                        Console.WriteLine("How is my pet doing?");
                        
                        break;
                    case "5":
                        // VisitDoc();
                        Console.WriteLine("My pet isn't doing so good. I need to take him to the doctor.");
                        break;
                    case "6":
                        // AddPett();
                        Console.WriteLine("Which pet would you like to add to the shelter?");
                        newPet.SetPetType(Console.ReadLine());
                        masterPetList.AddPet(newPet);
                        break;
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
