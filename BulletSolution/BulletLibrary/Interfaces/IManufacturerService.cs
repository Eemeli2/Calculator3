using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulletLibrary.Interfaces
{
    /// <summary>
    /// Defines manufacture service contract.
    /// </summary>
    public interface IManufacturerService
    {
        /// <summary>
        /// Get manufacturer by id.
        /// </summary>
        /// <param name="manufacturerId">Manufacturer id.</param>
        /// <returns><see cref="Manufacturer"/>.</returns>
        Task<Manufacturer> GetById(Guid manufacturerId);

        /// <summary>
        /// Gets all manufacturers.
        /// </summary>
        /// <returns>/>A collection of <see cref="Manufacturer"/>.</returns>
        Task<IEnumerable<Manufacturer>> GetAll();

        /// <summary>
        /// Inserts a new manufacturer.
        /// </summary>
        /// <param name="manufacturer">Instance of <see cref="Manufacturer"/>.</param>
        /// <returns>Manufacturer id.</returns>
        Task<Guid> Insert(Manufacturer manufacturer);
    }
}
