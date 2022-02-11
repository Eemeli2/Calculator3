using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// Public class of Diameter.
    /// </summary>
    public class Diameter
    {
        /// <summary>
        /// Unit type for enum.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Regular unit of measurement.
            /// </summary>
            Mm,

            /// <summary>
            /// Imperial unit of measurement.
            /// </summary>
            Inch,
        }

        /// <summary>
        /// Gets or sets the Value for <see cref="Diameter"/>.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the Unit for <see cref="Diameter"/>¨.
        /// </summary>
        public Unit UnitType { get; set; }
    }
}
