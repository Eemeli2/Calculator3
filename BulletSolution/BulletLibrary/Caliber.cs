using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// Public class Caliber.
    /// </summary>
    public class Caliber
    {
        /// <summary>
        /// Gets or sets the caliber id.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the primertype.
        /// </summary>
        public Primer.PrimerType PrimerType { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets diameter of Caliber and bullet.
        /// </summary>
        public Diameter? Diameter { get; set; }
    }
}
