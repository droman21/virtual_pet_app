using System;
using System.Reflection.Metadata.Ecma335;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicPetTests
    {
        public OrganicPet testPet;

        public OrganicPetTests()
        {
            testPet = new OrganicPet("Dan","Fish");
        }

        [Fact]
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
            testPet.SetName("Fido");
            Assert.Equal("Fido", testPet.Name);
        }
        public string Name
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        [Fact]
        public void Pet_Should_Have_Species()
        {
            Assert.NotNull(testPet.Species);
            testPet.Species = "Pet Species";
            Assert.Equal("Pet Species", testPet.Species);
        }

        [Fact]
        public void SetSpecies_Should_Assign_Pet_Species_Property()
        {
            testPet.SetSpecies("Dog");
            Assert.Equal("Dog", testPet.Species);
        }

        [Fact]
        public void GetSpecies_Should_Get_Pet_Species_Value()
        {
            testPet.SetSpecies("Dog");
            string testPetSpecies = testPet.GetSpecies();
            Assert.Equal("Dog", testPetSpecies);
        }

        [Fact]
        public void Pet_Should_Have_Hunger()
        {
            testPet.Hunger = 50;
            Assert.Equal(50, testPet.Hunger);
        }

        [Fact]
        public void GetHunger_Should_Return_Initial_Hunger_Level_Of_50()
        {
            int testPetHunger = testPet.Hunger;

            Assert.Equal(50, testPetHunger);
        }

        [Fact]
        public void Pet_Should_Have_Boredom()
        {
            testPet.Boredom = 100;
            Assert.Equal(100, testPet.Boredom);
        }

        [Fact]
        public void GetBoredom_Should_Return_Initial_Boredom_Level_Of_60()
        {
            int testPetBoredom = testPet.Boredom;
            Assert.Equal(60, testPet.Boredom);
        }

        [Fact]
        public void Pet_Should_Have_Health()
        {
            {
                testPet.Health = 30;
                Assert.Equal(30, testPet.Health);
            }
        }

        [Fact]
        public void GetHealth_Should_Return_Initial_Health_Level_Of_30()
        {
            int testPetHealth = testPet.Health;
            Assert.Equal(30, testPet.Health);
        }

        [Fact]
        public void Feed_Should_Decrease_Hunger_By_40()
        {
            testPet.Hunger = 50;
            int testPetHunger = testPet.Hunger;
            testPet.Feed();
            Assert.Equal(testPetHunger - 10, testPet.Hunger);
        }

        [Fact]
        public void SeeDoctor_Should_Increase_Health_By_30()
        {
            testPet.Health = 30;
            int testPetHealth = testPet.Health;
            testPet.SeeDoctor();
            Assert.Equal(testPetHealth + 30, testPet.Health);
        }

        [Fact]
        public void Play_Should_Increase_Hunger_By_10()
        {
            testPet.Hunger = 50;
            int testPetHealth = testPet.Hunger;
            testPet.Play();
            Assert.Equal(testPetHealth + 10, testPet.Hunger);
        }

        [Fact]
        public void Play_Should_Decrease_Boredom_By_20()
        {
            testPet.Boredom = 60;
            int testPetBoredom = testPet.Boredom;
            testPet.Play();
            Assert.Equal(testPetBoredom - 20, testPet.Boredom);
        }

        [Fact]
        public void Play_Should_Increase_Health_By_10()
        {
            testPet.Health = 30;
            int testPetHealth = testPet.Health;
            testPet.Play();
            Assert.Equal(testPetHealth + 10, testPet.Health);
        }

        [Fact]
        public void Tick_Should_Increase_Hunger_By_5()
        {
            testPet.Hunger = 50;
            int testPetHunger = testPet.Hunger;
            testPet.Tick();
            Assert.Equal(testPetHunger + 5, testPet.Hunger);
        }

        [Fact]
        public void Tick_Should_Increase_Boredom_By_5()
        {
            testPet.Boredom = 60;
            int testPetBoredom = testPet.Boredom;
            testPet.Tick();
            Assert.Equal(testPetBoredom + 5, testPet.Boredom);
        }

        [Fact]
        public void Tick_Should_Decrease_Health_By_5()
        {
            testPet.Health = 30;
            int testPetHealth = testPet.Health;
            testPet.Tick();
            Assert.Equal(testPetHealth - 5, testPet.Health);
        }
    }
}
