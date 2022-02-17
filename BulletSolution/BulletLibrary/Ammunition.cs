using System;
using System.Collections.Generic;
using System.Text;
using BulletLibrary.Interfaces;

namespace BulletLibrary
{
    /// <summary>
    /// Public class load.
    /// </summary>
    public class Ammunition
    {
        private Case? _case;
        private Bullet? bullet;
        private Primer? primer;

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
                if (value != null && Primer != null && !Primer!.TypeOf.Equals(value!.Caliber!.PrimerType!))
                {
                    throw new InvalidOperationException("Primer size does not match");
                }

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

                bullet = value;
            }
        }

        /// <summary>
        /// Gets or sets the primertype.
        /// </summary>
        public Primer? Primer
        {
            get => primer;
            set
            {
                if (value != null && Case != null && !Case!.Caliber!.PrimerType!.Equals(value!.TypeOf!))
                {
                    throw new InvalidOperationException("Primer size does not match");
                }

                primer = value;
            }
        }
    }
}
