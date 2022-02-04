using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Cat : Animal
    {
        public override string Name => "Cat";

        public override string Sound => "Meow";

        public override string Description => "The cat is a domestic species of a small carnivorous mammal. It is the only domesticated species in the family Felidae";

        protected override string FileName => "Meow.mp3";
    }
}
