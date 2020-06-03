using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    class OrganicPet : Pet
    {
        public void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }
    }
}
