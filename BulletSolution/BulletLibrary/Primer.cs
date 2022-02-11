using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// Class primer refering component.
    /// </summary>
    public class Primer : Component
    {
        /// <summary>
        /// Public enum PrimerType.
        /// </summary>
        public enum PrimerType
        {
            /// <summary>
            /// Small primer.
            /// </summary>
            Small,

            /// <summary>
            /// Large primer.
            /// </summary>
            Large,

            /// <summary>
            /// Magnum primer.
            /// </summary>
            Magnum,
        }

        /// <summary>
        /// Gets or sets PrimerType.
        /// </summary>
        public PrimerType TypeOf { get; set; }
    }
}
