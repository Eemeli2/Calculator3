using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Crow : Animal
    {
        public override string Name => "Crow";

        public override string Sound => "Caw";

        public override string Description => "A crow is a bird of the genus Corvus, or more broadly a synonym for all of Corvus.";

        protected override string FileName => "Caw.mp3";
    }
}
