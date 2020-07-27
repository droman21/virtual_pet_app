using ConsoleTables;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Shelter petShelter = new Shelter();
            bool keepThinking = true;
            while (keepThinking)
            {
                petShelter.PrintAllPets();
                Console.WriteLine("Hi and Welcome to the Perrysburg Pet Shelter!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. I'm Bringing in a New Organic Pet");
                Console.WriteLine("2. I'm Bringing in a New Robot Pet");
                Console.WriteLine("3. Feed all of the Organic Pets");
                Console.WriteLine("4. Play with all of the Pets");
                Console.WriteLine("5. Play with a Single Pet");
                Console.WriteLine("6. Adopt a Pet");
                Console.WriteLine("7. Give Robot Pet Oil");
                Console.WriteLine("8. Give Robot Pet Maintenance");
                Console.WriteLine("9. Leave the Shelter");
        
                string menuChoice = Console.ReadLine().ToLower();
                switch (menuChoice)
                {
                    case "1":
                        {
                            Console.WriteLine("What is your organic pet's name?");
                            string name = Console.ReadLine();

                            Console.WriteLine("What species is your organic pet? (Examples: tiger, dog, fish");
                            string species = Console.ReadLine();
                            OrganicPet newPet = new OrganicPet(name, species);
                            petShelter.AddPet(newPet);
                            petShelter.PrintAllPets();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "2":
                        {
                            Console.WriteLine("What is your robot pet's name?");
                            string name = Console.ReadLine();

                            Console.WriteLine("What type is your robot pet? (Examples: Robot, Cyborg, Transformer");
                            string type = Console.ReadLine();
                            RoboticPet newPet = new RoboticPet(name, type);
                            petShelter.AddPet(newPet);
                            petShelter.PrintAllPets();
                            Console.WriteLine("\n");
                        }
                        break;
                    case "3":
                        {
                            petShelter.PrintAllPets();
                            petShelter.FeedAll();
                            Console.WriteLine("You fed the pets!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "4":
                        {
                            petShelter.PrintAllPets();
                            petShelter.PlayAll();
                            Console.WriteLine("You played with the pets!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "5":
                        {
                            petShelter.PrintAllPets();
                            Console.WriteLine("Which pet would you like to play with?");
                            string petToPlay = Console.ReadLine();
                            Pet myPet = petShelter.PetSelect(petToPlay);
                            myPet.Play();
                            Console.WriteLine($"You played with {myPet.GetName()}!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "6":
                        {
                            petShelter.PrintAllPets();
                            Console.WriteLine("Which pet would you like to adopt?");
                            string petToAdopt = Console.ReadLine();
                            Pet pet = petShelter.PetSelect(petToAdopt);
                            petShelter.RemovePet(pet);
                            Console.WriteLine($"You gave {pet.GetName()} a good home!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "7":
                        {
                            petShelter.PrintAllPets();
                            petShelter.GiveOil();
                            Console.WriteLine("You gave them oil!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "8":
                        {
                            petShelter.PrintAllPets();
                            petShelter.GiveMaintenance();
                            Console.WriteLine("You gave them maintenance!");
                            Console.WriteLine("\n");
                        }
                        break;
                    case "9":
                        {
                            keepThinking = false;
                            Console.WriteLine("Good Bye! Thanks for Visiting!");
                        }
                        break;
                    default:
                        break;

                        
                }
            }

        }
        
    }

}
