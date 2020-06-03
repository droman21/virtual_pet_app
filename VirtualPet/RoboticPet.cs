using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RoboticPet : Pet
    {

        public string RobotPetType { get; set; }
        public string RobotPetName { get; set; }
        public int OilLevel { get; set; }
        public int MaintenanceLevel { get; set; }
        public int PerformanceLevel { get; set; }


        
        public RoboticPet (string robotname, string type)
        {
            Name = robotname;
            PetType = type;
            OilLevel = 45;
            Boredom = 60;
            PerformanceLevel = 30;
            MaintenanceLevel = 15;
        }
        public RoboticPet()
        {
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
        public string GetRobotName()
        {
            return Name;
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
        public void GiveMaintenance()
        {
            OilLevel += 15;
            PerformanceLevel += 35;
        }
    }


}
    

