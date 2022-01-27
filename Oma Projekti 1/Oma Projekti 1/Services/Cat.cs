using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Cat : IAnimal
    {
        public string Name => "Cat";

        public string GetSound()
        {
            return "Meow"; 
        }
    }
}
