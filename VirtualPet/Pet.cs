using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {


        public string Species { get; set; }
        public string PetType { get; set; }
        public string Name { get; set; }
        public int Boredom { get; set; }
        public int Hunger { get; set; }
        public int Health { get; set; }

        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }
        public Pet()
        {
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPetType(string type)
        {
            PetType = type;
        }
        public string GetPetType()
        {
            return PetType;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetSpecies()
        {
            return Species;
        }
        public int GetHunger()
        {
            return Hunger;
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetBoredom()
        {
            return Boredom;
        }
        public void Feed()
        {
            Hunger -= 40;
        }
        public void SeeDoctor()
        {
            Health += 30;
        }
        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }
        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
        public void AddPet()
        {
            //All options for adding pet
        }
        public void PrintPetStatus()
        {

        }
    }
    

}
