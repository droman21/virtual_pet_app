using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{

    public class RobotPetTests
    {
        private RoboticPet testPet = null;

        public RobotPetTests()
        {
            testPet = new RoboticPet("Darth Vader", "CAT");
        }
        public void Pet_Constructor_Should_Instantiate_Pet_Object()
        {
            Assert.NotNull(testPet);
        }
        [Fact]
        public void Pet_Should_Have_Name()
        {
            Assert.NotNull(testPet.Name);
        }
        [Fact]
        public void SetName_Should_Assign_Pet_Name_Property()
        {
            testPet.SetName("Fluffy");
            Assert.Equal("Fluffy", testPet.Name);
        }
        [Fact]
        public void GetName_Should_Get_Pet_Name_Value()
        {
            testPet.SetName("Vulcan");
            string testPetName = testPet.Name;
            Assert.Equal("Vulcan", testPetName);
        }
        [Fact]
        public void Pet_Should_Have_Species()
        {
            Assert.NotNull(testPet.Species);
        }
        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.SetSpecies("Cat");
            Assert.Equal("Cat", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.SetSpecies("Dog");
            string testPetSpecies = testPet.Species;
            Assert.Equal("Dog", testPetSpecies);
        }
        [Fact]
        public void Pet_Should_Have_Oil()
        {
            Assert.NotNull(testPet.OilLevel.ToString());
        }
        [Fact]
        public void Pet_Should_Have_Performance()
        {
            Assert.NotNull(testPet.PerformanceLevel.ToString());
        }
        [Fact]
        public void Pet_Should_Have_Maintenance()
        {
            Assert.NotNull(testPet.MaintenanceLevel.ToString());
        }
        [Fact]
        public void Tick_Should_Decrease_All_By_5()
        {
            testPet.Tick();
            Assert.Equal(95, testPet.MaintenanceLevel);
        }
        [Fact]
        public void Pet_Play()
        {
            int Level = testPet.Boredom;
            testPet.Play();
            Assert.True(Level > testPet.Boredom);
        }
        [Fact]
        public void Pet_See_Mechanic()
        {
            int Level = testPet.MaintenanceLevel;
            testPet.Tick();
            Assert.True(Level > testPet.MaintenanceLevel);
            testPet.SeeMechanic();
            Assert.True(Level <= testPet.MaintenanceLevel);
        }
        [Fact]
        public void Pet_Perform_Oil()
        {
            int Level = testPet.OilLevel;
            testPet.Tick();
            Assert.True(Level > testPet.OilLevel);
            testPet.GiveOil();
            Assert.True(Level <= testPet.OilLevel);
        }
        [Fact]
        public void Pet_Perform_Maintenance()
        {
            int Level = testPet.MaintenanceLevel;
            testPet.Tick();
            Assert.True(Level > testPet.MaintenanceLevel);
            testPet.SeeMechanic();
            Assert.True(Level <= testPet.MaintenanceLevel);
        }

    }
}
