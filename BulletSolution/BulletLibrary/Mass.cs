using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// public class of Mass.
    /// </summary>
    public class Mass
    {
        /// <summary>
        /// UnitType for enum.
        /// </summary>
        public enum Unit
        {
            /// <summary>
            /// Unit of mass for grams.
            /// </summary>
            Gram,

            /// <summary>
            /// Unit of mass for grains.
            /// </summary>
            Grain,
        }

        /// <summary>
        /// Gets or sets value for <see cref="Mass"/>.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets Unit for <see cref="Mass"/>.
        /// </summary>
        public Unit UnitType { get; set; }
    }
}
