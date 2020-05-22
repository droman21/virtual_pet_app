using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {


        public string Species { get; set; }
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
        public string GetName()
        {
            return Name;

        }
        public string GetSpecies()
        {
            return Species;
        }
        public void Feed()
        {
            Hunger = Hunger - 40;
        }
        public void SeeDoctor()
        {
            Health = Health + 30;
        }
        public void Play()
        {
            Hunger = Hunger + 10;
            Boredom = Boredom - 20;
            Health = Health + 10;
        }
        public void Tick()
        {
            Hunger = Hunger + 5;
            Boredom = Boredom + 5;
            Health = Health - 5;
        }
    }
    

}
