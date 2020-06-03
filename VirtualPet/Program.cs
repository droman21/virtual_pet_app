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
            RoboticPet newRoboticPet = new RoboticPet();
            Shelter petShelter = new Shelter();
            petShelter.AddPet(newPet);
            petShelter.AddPet(newRoboticPet);
            bool keepThinking = true;

            while (keepThinking)
            {
                Console.WriteLine("Hi and Welcome to the Perrysburg Pet Shelter!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. I'm Bringing in a New Organic Pet");
                Console.WriteLine("2. I'm Brining in a New Robot Pet");
                Console.WriteLine("3. Feed all of the Organic Pets");
                Console.WriteLine("4. Play with all of the Pets");
                Console.WriteLine("5. Play with a Single Pet");
                Console.WriteLine("6. Adopt a Pet");
                Console.WriteLine("7. Give Robot Pet Oil");
                Console.WriteLine("8. Give Robot Pet Maintenance");
                Console.WriteLine("9. Leave the Shelter");
                //Console.Clear();
                string menuChoice = Console.ReadLine().ToLower();

                switch (menuChoice)
                {
                    case "1":
                        newPet = new Pet();
                        Console.WriteLine("What is your organic pet's name?");
                        string name = Console.ReadLine();
                        newPet.SetName(name);

                        Console.WriteLine("What species is your organic pet? (Examples: tiger, dog, fish");
                        string species = Console.ReadLine();
                        newPet.SetSpecies(species);
                        petShelter.AddPet(newPet);
                        petShelter.PrintAllPets();
                        Console.WriteLine("\n");
                        break;
                    case "2":
                        Console.WriteLine("What is your robot pet's name?");
                        string robotname = Console.ReadLine();
                        newRoboticPet.SetName(robotname);

                        Console.WriteLine("What type is your robot pet? (Examples: Robot, Cyborg, Transformer");
                        string type = Console.ReadLine();
                        newRoboticPet.SetRobotType(type);
                        petShelter.AddPet(newRoboticPet);
                        petShelter.PrintAllPets();
                        Console.WriteLine("\n");
                        break;
                    case "3":
                        petShelter.PrintAllPets();
                        petShelter.FeedAll();
                        Console.WriteLine("You fed the pets!");
                        Console.WriteLine("\n");
                        break;
                    case "4":
                        petShelter.PrintAllPets();
                        petShelter.PlayAll();
                        Console.WriteLine("You played with the pets!");
                        Console.WriteLine("\n");
                        break;
                    case "5":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to play with?");
                        string petToPlay = Console.ReadLine();
                        string roboticPetToPlay = Console.ReadLine();
                        newPet = petShelter.PetSelect(petToPlay);
                        newRoboticPet = (RoboticPet)petShelter.PetSelect(roboticPetToPlay);
                        petShelter.Play(newPet);
                        petShelter.Play(newRoboticPet);
                        Console.WriteLine($"You played with {newPet.GetName()}!");
                        Console.WriteLine($"You played with {newRoboticPet.GetName()}!");
                        Console.WriteLine("\n");
                        break;
                    case "6":
                        petShelter.PrintAllPets();
                        Console.WriteLine("Which pet would you like to adopt?");
                        string petToAdopt = Console.ReadLine();
                        newPet = petShelter.PetSelect(petToAdopt);
                        newRoboticPet = (RoboticPet)petShelter.PetSelect(petToAdopt);
                        petShelter.RemovePet(newPet);
                        petShelter.RemovePet(newRoboticPet);
                        Console.WriteLine($"You gave {newPet.GetName()} a good home!");
                        Console.WriteLine("\n");
                        break;
                    case "7":
                        petShelter.PrintAllPets();
                        petShelter.GiveOil();
                        Console.WriteLine("You fed the pets!");
                        Console.WriteLine("\n");
                        break;
                    case "8":
                        break;
                    case "9":
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
