using System;
using System.Collections.Generic;
using System.Text;

namespace Oma_Projekti_1.Services
{
    public class Alligator : Animal
    {
        public override string Name => "Alligator";

        public override string Sound => "Hiss";

        public override string Description => "An alligator is a crocodilian in the genus Alligator of the family Alligatoridae";

        protected override string FileName => "AlligatorBellow.mp3";

    }
}
