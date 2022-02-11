using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalKingdom.Forms.Core.Interfaces
{
    public interface IAnimal
    {
        string Name { get;}

        string Sound { get; }

        string Description { get;}



        void PlaySound();
    }
}
