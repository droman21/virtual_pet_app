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
            OilLevel += 15;
            PerformanceLevel += 35;
        }

    }


}
    

