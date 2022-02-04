using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Dog : Animal
    {
        public override string Name => "Dog";

        public override string Sound => "Bark";

        public override string Description => "The dog or domestic dog is a domesticated descendant of the wolf which is characterized by an upturning tail.";

        protected override string FileName => "Bark.mp3";
    }
}
