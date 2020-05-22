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
            Hunger = 30;
            Boredom = 25;
            Health = 47;
        }
        public Pet()
        {
            Hunger = 30;
            Boredom = 25;
            Health = 47;
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
            Hunger = Hunger - 15;
        }
    }
    

}
