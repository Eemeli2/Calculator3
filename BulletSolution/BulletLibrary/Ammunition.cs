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
        private Case? _case;
        private Bullet? bullet;

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
        public Case? Case
        {
            get => _case;
            set
            {
                if (value != null && Bullet != null && !Bullet!.Diameter!.Equals(value!.Caliber!.Diameter!))
                {
                    throw new InvalidOperationException("Diameters do not match");
                }

                _case = value;
            }
        }

        /// <summary>
        /// Gets or sets the bullet used for making ammunition.
        /// </summary>
        public Bullet? Bullet
        {
            get => this.bullet;
            set
            {
                if (value != null && this.Case != null && !this.Case!.Caliber!.Diameter!.Equals(value!.Diameter!))
                {
                    throw new InvalidOperationException("Diameters do not match");
                }

                this.bullet = value;
            }
        }

        /// <summary>
        /// Gets or sets the primertype.
        /// </summary>
        public Primer? Primer { get; set; }
    }
}
