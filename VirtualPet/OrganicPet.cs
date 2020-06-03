using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        public int Hunger { get;  set; }
        public int Thirst { get;  set; }
        public int Waste { get; set; }
        public int Sleepiness { get;  set; }
        public int Sickness { get; set; }
       
        public int Health { get; set; }




        public OrganicPet(String petName, string species) : base(petName, species)
        {

           
            Hunger = 50;
            Boredom = 60;
            Health = 30;
        }

        

        public override void Tick()
        {
            
            Boredom += 5;
            Hunger += 5;
            Health -= 5;

           
        }


        public void SeeDoctor()
        {
            Health += 30;
            Sickness = 0;
            Console.WriteLine("Visited the doctor");
        }

        public override void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
            Console.WriteLine("Played with pet");
        }

        /// <summary>
        /// Decrease_Hunger_By_40
        /// </summary>
        public void Feed()
        {
            Hunger -= 40;
            if (Hunger < 0)
                Hunger = 0;

            Console.WriteLine("Fed the pet");
        }

        internal void Rest()
        {
            Sleepiness = 0;
            Console.WriteLine("Rested pet");
        }
        public override void GetStatus()
        {

            Console.WriteLine($"Name: {this.Name} | Species: {this.Species} | Hunger: {this.Hunger} | Boredom: {this.Boredom} | Health: {this.Health}");

        }
    }
}
