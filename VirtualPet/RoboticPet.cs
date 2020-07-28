using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class RoboticPet : Pet
    {
        public int OilLevel { get; set; }
        public int MaintenanceLevel { get; set; }
        public int PerformanceLevel { get; set; }

        public RoboticPet (string petName, string species):base(petName, species)
        {
            this.Name = petName;
            OilLevel = 45;
            Boredom = 60;
            PerformanceLevel = 30;
            MaintenanceLevel = 15;   
        }
        public void SetRobotName(string robotname)
        {
            Name = robotname;
        }
        public void SetRobotType(string type)
        {
            PetType = type;
        }
        public string GetRobotType()
        {
            return PetType;
        }
        public int GetOilLevel()
        {
            return OilLevel;
        }
        public void GiveOil()
        {
            OilLevel += 35;
        }
        public void RobotPlay()
        {
            OilLevel -= 5;
            Boredom -= 10;
        }
        public int GetMaintenance()
        {
           return MaintenanceLevel;
        }
        public new void GiveMaintenance()
        {
            OilLevel += 15;
            PerformanceLevel += 35;
        }
        public override void GetStatus()
        {
            Console.WriteLine($"Name: {this.Name} | Species: {this.Species} | Hunger: {this.OilLevel} | Boredom: {this.Boredom} | Health: {this.MaintenanceLevel}");
        }
        public override void Play()
        {
            Boredom -= 5;
            OilLevel -= 5;
            PerformanceLevel += 5;
        }
        public override void Tick()
        {
            MaintenanceLevel -= 5;
            OilLevel -= 5;
            PerformanceLevel -= 5;
        }
        public void SeeMechanic()
        {
            MaintenanceLevel = 100;
        }

    }

}
    

