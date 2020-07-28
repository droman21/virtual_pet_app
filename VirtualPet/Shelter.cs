using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using VirtualPet;

namespace VirtualPet
{
    public class Shelter
    {
         
        public List<Pet> allPets = new List<Pet>();

        private bool Test()
        {
            return test(new List<string>() { "Name", "Species" });
        }
        private bool test(List<string> Lst = null)
        {
            List<string> tempList;
            if (Lst == null)
                tempList = new List<string>() { "Name", "Species" };
            else
                tempList = Lst;

            return false;
        }

        internal void ShowOrganicPets()
        {
            throw new NotImplementedException();
        }

        public Pet PetSelect(string name)
        {
            foreach (Pet pet in allPets)
            {
                if (name == pet.GetName())
                {
                    Console.WriteLine("Here's your pet!");
                    return pet;
                }
            }
            return null;
        }
        public RoboticPet RobotPetSelect(string robotname)
        {
            foreach (Pet pet in this.allPets)
            {
                if (robotname == pet.Name)
                {
                    Console.WriteLine("Here's your robot pet!");
                    RoboticPet roboPet = (RoboticPet)pet;
                    return roboPet;
                }
            }
            return null;
        }
        public void PrintAllPets()
        {
            foreach (Pet pet in allPets)
            {
                pet.GetStatus();
            }
        }
        public void FeedAll()
        {
            foreach (Pet pet in allPets)
            {
                if(pet is OrganicPet)
                {
                    ((OrganicPet)pet).Feed();
                }
            }
        }
        public void PlayAll()
        {
            foreach (OrganicPet pet in allPets)
            {
                pet.Play();
            }
        }
        public void DoctorAll()
        {
            foreach (Pet pet in allPets)
            {
                if (pet is OrganicPet)
                {
                    ((OrganicPet)pet).SeeDoctor();
                }
            }
        }
        public void AddPet(Pet pet)
        {
            allPets.Add(pet);
        }
        public void RemovePet(Pet pet)
        {
            allPets.Remove(pet);
        }
        public void GiveOil()
        {
            foreach (RoboticPet pet in allPets)
            {
                pet.GiveOil();
            }
        }
        public void GiveMaintenace()
        {
            foreach (RoboticPet pet in allPets)
            {
                pet.GiveMaintenance();
            }
        }
        public void RobotPlay()
        {
            foreach (RoboticPet pet in allPets)
            {
                pet.RobotPlay();
            }
        }
        public void ShowOrganicPets(List<OrganicPet> organicPets)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nORGANIC PETS");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Pet Name   Type      Boredom | Health | Hunger |");
            Console.ResetColor();

            if (organicPets.Count >= 1)
            {
                foreach (OrganicPet someOrganicPet in organicPets)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"{someOrganicPet.GetName().PadRight(11, ' ')}");
                    Console.Write($"{someOrganicPet.GetSpecies().PadRight(12, ' ')}");
                    Console.ResetColor();
                    Console.Write($"{someOrganicPet.GetBoredom().ToString().PadRight(10, ' ')}");
                    Console.Write($"{someOrganicPet.GetHealth().ToString().PadRight(8, ' ')}");
                    Console.Write($"{someOrganicPet.GetHunger().ToString().PadRight(11, ' ')}");
                }
            }
            else
            {
                ShowNoOrganicPetsInShelterMessage();
            }
        }
        private void ShowNoOrganicPetsInShelterMessage()
        {
            throw new NotImplementedException();
        }

    }

}
