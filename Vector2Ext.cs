using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.Xna.Framework
{
    public partial struct Vector2
    {
        /// <summary>
        /// Gets a <see cref="Point"/> representation for this object.
        /// </summary>
        /// <returns>A <see cref="Point"/> representation for this object.</returns>
        public Point ToPoint()
        {
            return new Point((int) X,(int) Y);
        }
    }
}
