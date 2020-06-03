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
        public List<RoboticPet> allRobotPets = new List<RoboticPet>();
        
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
            foreach (RoboticPet pet in allPets)
            {
                if (robotname == pet.GetRobotName())
                {
                    Console.WriteLine("Here's your pet!");
                    return pet;
                }
            }
            return null;
        }
        public void PrintAllPets()
        {
            foreach (Pet pet in allPets)
            {
                Console.WriteLine($"Name: {pet.Name} | Species: {pet.Species} | Hunger: {pet.Hunger} | Boredom: {pet.Boredom} | Health: {pet.Health}");
            }
        }
        public void FeedAll()
        {
            foreach (Pet pet in allPets)
            {
                pet.Feed();
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
                pet.SeeDoctor();
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
        public void RobotPlay()
        {
            foreach (RoboticPet pet in allPets)
            {
                pet.RobotPlay();
            }
        }
        public void GiveMaintenance()
        {
            foreach (RoboticPet pet in allPets)
            {
                pet.GiveMaintenance();
            }
        }
    }

}
