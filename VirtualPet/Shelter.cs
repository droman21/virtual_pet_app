using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;
using VirtualPet;

namespace VirtualPet
{
    public class Shelter
    {
        //Ability for players to admit pets into the shelter or adopt them
       public void AddPet (Pet myPet)
        {
            PetList.Add(myPet);
        }



        //Ability for players to see a list of all pets in the shelter
        List<Pet> PetList = new List<Pet>();

        

        //Ability for players to see the current status of all pets at once, such as hunger, boredom, and health
        public void PrintAllPets()
        {

        }



        //Ability for players to choose to interact with one pet or multiple pets, such as feed, play, and take to doctor
        public void FeedAll()
        {
            foreach (Pet pet in PetList)
            {
                pet.Feed();
            }
        }
        public void PlayAll()
        {
            foreach (Pet pet in PetList)
            {
                pet.Play();
            }
        }
        public void DoctorAll()
        {
            foreach (Pet pet in PetList)
            {
                pet.SeeDoctor();
            }
        }
    }
}
