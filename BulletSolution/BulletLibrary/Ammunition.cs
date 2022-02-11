using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// Public class load.
    /// </summary>
    public class Ammunition
    {
        /// <summary>
        /// Gets or sets gunpoweder for ammunition.
        /// </summary>
        public Gunpowder? Gunpowder { get; set; }

        /// <summary>
        /// Gets or sets the Mass of gunpowder for ammunition.
        /// </summary>
        public Mass? PowderMass { get; set; }

        /// <summary>
        /// Gets or sets case to be loaded.
        /// </summary>
        public Case? Case { get; set; }

        /// <summary>
        /// Gets or sets the Primer type of ammunition.
        /// </summary>
        public Primer.PrimerType PrimerType { get; set; }

        /// <summary>
        /// Gets or sets the bullets used for making ammunition.
        /// </summary>
        public Bullets? Bullets { get; set; }
    }
}
