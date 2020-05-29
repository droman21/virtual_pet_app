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
        public string Species { get; set; }
        public string PetType { get; set; }
        public string Name { get; set; }
        public int Boredom { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }

        public List<Pet> allPets = new List<Pet>();

        
        
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
            foreach (Pet pet in allPets)
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
        public void Play(Pet pet)
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }
    }
}
