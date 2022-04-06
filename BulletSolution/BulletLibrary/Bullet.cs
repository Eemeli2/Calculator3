using System;

namespace BulletLibrary
{
    /// <summary>
    /// Public class of bullets.
    /// </summary>
    public class Bullet : Component
    {
        /// <summary>
        /// Gets or sets mass for <see cref="Bullet"/>.
        /// </summary>
        public Mass? Mass { get; set; }

        /// <summary>
        /// Gets or sets Diameter for <see cref="Bullet"/>.
        /// </summary>
        public Diameter? Diameter { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Manufacturer?.Name ?? string.Empty} {Name} {Diameter}";
        }
    }
}
