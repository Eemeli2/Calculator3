using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdom.Forms.Core.Interfaces
{
    public class Alligator : Animal
    {
        public override string Name => "Alligator";

        public override string Sound => "Hiss";

        public override string Description => "Placeholder";

        protected override string FileName => "AlligatorBellow.mp3";

    }
}
