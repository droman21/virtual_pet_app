using System;
using System.Collections.Generic;
using System.Text;
using VirtualPet;
using Xunit;

namespace Shelter.Tests
{
    public class ShelterTests
    {
        public VirtualPet.Shelter myShelter = null;
        public ShelterTests()
        {
            myShelter = new VirtualPet.Shelter();
            OrganicPet myPet = new OrganicPet("Steve", "Tiger");
            myShelter.AddPet(myPet);
        }

        [Fact]
        public void PetShelter_DisplayAllPets()
        {
            //Arrange

            //Act
            myShelter.PrintAllPets();

            //Assert
            //Assert.("", petList);


        }
        [Fact]
        public void PetShelter_AddPet()
        {
            
            myShelter.AddPet(new OrganicPet("Nick", "Tiger"));

             Pet myPet = myShelter.PetSelect("Nick");

            Assert.NotNull(myPet);
            
           

            


        }
        [Fact]
        public void PetShelter_AllPet_Interact()
        {


           myShelter.FeedAll();
           //Assert.NotEqual(totalHunger, newHungerLevel);

        }
        [Fact]
        public void PetShelter_OnePet_Interact()
        {

            
            Pet myPet = myShelter.PetSelect("Steve");

            //Assert.Equal(20, level);



        }
        [Fact]
        public void PetShelter_Adopt()
        {


            Pet myPet = myShelter.PetSelect("Steve");
            myShelter.RemovePet(myPet);

        }
    }
}
