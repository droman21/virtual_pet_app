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
        public string myPetShelter { get; set; }

        public List<Pet> allPets = new List<Pet>();
        
        List<Pet> PetList = new List<Pet>();
       

        public void PrintAllPets()
        {
            foreach (Pet pet in PetList)
            {
                Console.WriteLine($"{pet.Name} | Hunger{pet.Hunger} | Boredom{pet.Boredom} | Health{pet.Health}");
            }
        }

        public void FeedAll()
        {
            foreach (Pet pet in PetList)
            {
                pet.Feed();
            }
        }
        public void PlayAll()
        {
            foreach (Pet pet in PetList)
            {
                pet.Play();
            }
        }
        public void DoctorAll()
        {
            foreach (Pet pet in PetList)
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

    }
}
