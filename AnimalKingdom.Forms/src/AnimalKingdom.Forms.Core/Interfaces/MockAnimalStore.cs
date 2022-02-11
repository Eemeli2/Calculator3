using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnimalKingdom.Forms.Core.Interfaces
{
    public class MockAnimalStore : IAnimalStore
    {
        public async Task<IEnumerable<IAnimal>> GetAnimalsAsync(bool forceRefresh = false)
        {
            return await Task.Run(() =>
            {
                return new IAnimal[]
                {
                    new Alligator(),
                    new Alligator()
                };
            });
        }
    }
}
