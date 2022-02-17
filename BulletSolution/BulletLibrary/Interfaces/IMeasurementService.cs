using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulletLibrary.Interfaces
{
    /// <summary>
    /// Public Interface for measurements.
    /// </summary>
    public interface IMeasurementService
    {
        /// <summary>
        /// Gets all masses.
        /// </summary>
        /// <returns>A<see cref="Task"/>.</returns>
        Task<IEnumerable<Mass>> GetAllMasses();

        /// <summary>
        /// Gets all Diameters.
        /// </summary>
        /// <returns>A<see cref="Task"/>.</returns>
        Task<IEnumerable<Diameter>> GetAllDiameters();

        /// <summary>
        /// Inserts mass.
        /// </summary>
        /// <param name="mass">Mass id.</param>
        /// <returns> Returns Id of Mass. <see cref="Mass"/>.</returns>
        Task<Guid> InsertMass(Mass mass);

        /// <summary>
        /// Inserts Diameter.
        /// </summary>
        /// <param name="diameter"> Diameter id.</param>
        /// <returns> Returns Id of diameter. <see cref="Diameter"/>.</returns>
        Task<Guid> InsertDiameter(Diameter diameter);
    }
}
