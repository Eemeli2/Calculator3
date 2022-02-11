using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Forms.Core.Interfaces
{
    public interface IAnimalStore
    {


        Task<IEnumerable<IAnimal>> GetAnimalsAsync(bool forceRefresh = false);
    }
}
