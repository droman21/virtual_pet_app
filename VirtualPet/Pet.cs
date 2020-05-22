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
        public Pet(string name, string species)
        {
            Name = name;
            Species = species;
        }
        public void SetSpecies(string species)
        {
            Species = species;
        }
        public void SetName(string name)
        {
            Name = name;
         
        }
        public string GetName(string name)
        {
            return name;
    }
        }
        public string GetSpecies(string name)
        {
            return species;
        }
        public double Hunger()
        {
        return Hunger;
        }
        public double Boredom { get; set; }
    

}
