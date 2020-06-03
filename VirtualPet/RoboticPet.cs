using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RoboticPet : Pet
    {
        //Add Robotic Pets to the Shelter

        //Play with Robotic Pets

        //Give Oil to Robotic Pets

        //Take Robotic Pet For Maintenance

        public string RobotPetType { get; set; }
        public string RobotPetName { get; set; }
        public int GiveRobotOil { get; set; }
        

        public RoboticPet(string robotname, string type)
        {
            Name = robotname;
            PetType = type;
            Boredom = 60;
            OilLevel = 60;
            Performance = 30;
        }
        public RoboticPet()
        {
            Boredom = 60;
            OilLevel = 60;
            Performance = 30;
            MaintenanceLevel = 45;
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
        public string GetRobotName()
        {
            return Name;
        }
        public int GetMaintenance()
        {
            return MaintenanceLevel;
        }
        public int GetOilLevel()
        {
            return OilLevel;
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

    }


}
    }
}
