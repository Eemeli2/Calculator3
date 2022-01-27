using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Dog : IAnimal
    {
        public string Name => "Dog";

        public string GetSound()
        {
            return "Woof";
        }
    }
    

    
}
