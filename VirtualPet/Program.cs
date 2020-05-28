using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;
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
                Console.WriteLine("Hi and Welcome to the Perrysburg Pet Shelter!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Feed the Pets");
                Console.WriteLine("2. Play with all of the Pets");
                Console.WriteLine("3. Play with a Pet");
                Console.WriteLine("4. Adopt a Pet");
                Console.WriteLine("5. Admit a Pet");
                Console.WriteLine("6. Quit");

                string menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "1":
                        petShelter.PrintAllPets();
                        petShelter.FeedAll();
                        Console.WriteLine("You feed the pets!");
                        break;
                    case "2":
                        petShelter.PrintAllPets();
                        petShelter.PlayAll();
                        Console.WriteLine("You played with the pets!");
                        break;
                    case "3":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to play with?");
                        int partNumber = Convert.ToInt32(Console.ReadLine());
                        Pet petToChoose = petShelter.FindPetByIndex(petNumber - 1);
                        petToChoose.Play();
                        break;
                    case "4":
                        petShelter.PrintAllPets();
                        
                        
                        break;
                    case "5":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to add to the shelter?");
                        newPet.SetPetType(Console.ReadLine());
                        masterPetList.AddPet(newPet);
                        break;
                    case "6":
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
