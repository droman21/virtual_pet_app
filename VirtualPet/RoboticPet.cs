using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class RoboticPet : Pet
    {

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
            MaintenanceLevel = 45;
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
        public void GiveOil()
        {
            OilLevel += 35;
        }
        public void GiveMaintenance()
        {
            MaintenanceLevel += 15;
        }
        public void GiveMaintenance()
        {
            OilLevel += 15;
            PerformanceLevel += 35;
        }

    }


}
    

