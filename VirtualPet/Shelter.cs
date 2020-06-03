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
        
        public Pet PetSelect(string name)
        {
            foreach (Pet pet in allPets)
            {
                if (name == pet.GetName())
                {
                    Console.WriteLine("Here's your organic pet!");
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
