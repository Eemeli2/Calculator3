using System;
using System.Collections.Generic;
using System.Text;

namespace BulletLibrary
{
    /// <summary>
    /// Public class component.
    /// </summary>
    public class Component
    {
        /// <summary>
        /// Gets or sets Manufacturer of bullet.
        /// </summary>
        public Manufacturer? Manufacturer { get; set; }

        /// <summary>
        /// Gets or sets name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the id for component.
        /// </summary>
        public Guid Id { get; set; }
    }
}
