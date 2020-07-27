﻿using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class OrganicPet : Pet
    {
        public int Thirst { get; set; }
        public int Waste { get; set; }
        public int Sleepiness { get; set; }
        public int Sickness { get; set; }


        public OrganicPet(string petName, string species) : base(petName, species)
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
            Console.WriteLine("You visited the Doctor!");
        }
        public override void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
            Console.WriteLine("You played with Pet!");
        }
        public void Feed()
        {
            Hunger -= 40;
            if (Hunger < 0)
                Hunger = 0;
            Console.WriteLine("You fed the Pet!");
        }
        internal void Rest()
        {
            Sleepiness = 0;
            Console.WriteLine("Rested the Pet");
        }
        public override void GetStatus()
        {
            Console.WriteLine($"Name: {this.Name} | Species: {this.Species} | Hunger: {this.Hunger} | Boredom: {this.Boredom} | Health: {this.Health}");
        }
    }
}
