using System;

namespace BulletLibrary
{
    /// <summary>
    /// Public class of bullets.
    /// </summary>
    public class Bullets : Component
    {
        /// <summary>
        /// Gets or sets mass for <see cref="Bullets"/>.
        /// </summary>
       public double Mass { get; set; }

        /// <summary>
        /// Gets or sets Diameter for <see cref="Bullets"/>.
        /// </summary>
       public double Diameter { get; set; }
    }
}
