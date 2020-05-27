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
                Console.WriteLine("Hello and welcome to the Perrysburg Pet Shelter!\n");
                Console.WriteLine("Which task would you like to perform?");
                Console.WriteLine("1. Feed the Pets");
                Console.WriteLine("2. Water the Pets");
                Console.WriteLine("3. Play with a Pet");
                Console.WriteLine("4. Adopt a Pet");
                Console.WriteLine("5. Admit a Pet");
                Console.WriteLine("6. Quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine("Please enter the type of pet you'd like to admit");
                        string petType = Console.ReadLine();
                        newPet.SetPetType(petType);
                        Console.WriteLine("Please enter your pet's name");
                        string petName = Console.ReadLine();
                        newPet.SetName(petName);
                        break;
                    case "2":
                        Console.WriteLine("Please enter your pet's name");
                        string petName = Console.ReadLine();
                        newPet.SetName(petName);
                        break;
                    case "3":
                        Console.WriteLine("Your pet is hunger. Feed it!");
                        string feedPet = Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("How is my pet doing?");
                        break;
                    case "5":
                        Console.WriteLine("My pet isn't doing so good. I need to take him to the doctor.");
                        break;
                    case "6":
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
