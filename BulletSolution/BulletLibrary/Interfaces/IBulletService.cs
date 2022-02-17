using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BulletLibrary.Interfaces
{
    /// <summary>
    /// Public Interface for Bullet.
    /// </summary>
    public interface IBulletService
    {
        /// <summary>
        /// Inserts new Bullet.
        /// </summary>
        /// <param name="bullet">bullet to insert.</param>
        /// <returns>True if succsessful otherwise false.</returns>
        Task<Guid> Insert(Bullet bullet);

        /// <summary>
        /// Get all bullets.
        /// </summary>
        /// <returns>IEnumerable of bullets.</returns>
        Task<IEnumerable<Bullet>> GetAll();

        /// <summary>
        /// Get all bullets by Diameter.
        /// </summary>
        /// <param name="diameter">Diameter of the bullet.</param>
        /// <returns>IEnumerable of all bullets that have <see cref="Diameter"/>.</returns>
        Task<IEnumerable<Bullet>> GetAllByDiameter(Diameter diameter);
    }
}
