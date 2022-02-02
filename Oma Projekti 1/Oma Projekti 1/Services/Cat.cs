using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Cat : IAnimal
    {
        public string Name => "Cat";

        public string Sound => "Meow";

        public string Description => "The cat is a domestic species of a small carnivorous mammal. It is the only domesticated species in the family Felidae";
    }
}
