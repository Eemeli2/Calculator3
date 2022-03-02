using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulletLibrary.Interfaces
{
    /// <summary>
    /// public interface ICaliberService.
    /// </summary>
    public interface ICaliberService
    {
        /// <summary>
        /// Get all diameters for Caliber.
        /// </summary>
        /// <param name="diameter">Diameter of the caliber.</param>
        /// <returns>IEnumerable of all calibers that have <see cref="Diameter"/>.</returns>
        Task<IEnumerable<Caliber>> GetAllByDiameter(Diameter diameter);

        /// <summary>
        /// Gets all Calibers.
        /// </summary>
        /// <returns>/>A collection of <see cref="Caliber"/>.</returns>
        Task<IEnumerable<Caliber>> GetAll();

        /// <summary>
        /// Inserts a new caliber.
        /// </summary>
        /// <param name="caliber">Instance of <see cref="Caliber"/>.</param>
        /// <returns>A Caliber.</returns>
        Task<Guid> Insert(Caliber caliber);
    }
}
