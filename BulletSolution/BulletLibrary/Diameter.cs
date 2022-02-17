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
        private const double InchInMm = 25.4;

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
        /// Gets or sets the diameter id.
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or sets the Value for <see cref="Diameter"/>.
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the Unit for <see cref="Diameter"/>¨.
        /// </summary>
        public Unit UnitType { get; set; }

        /// <inheritdoc/>
        public override string ToString()
        {
            var unit = UnitType == Unit.Mm ? "mm" : "\"";
            return $"{Value}{unit}";
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Diameter d && ValueInches(this).Equals(ValueInches(d));
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private static double ValueInches(Diameter d)
        {
            switch (d.UnitType)
            {
                case Unit.Mm: return Math.Round(d.Value / InchInMm, 3);
                default: return d.Value;
            }
        }
    }
}
