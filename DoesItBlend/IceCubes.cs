using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing ice cubes
    /// </summary>
    /// <summary>
    public class IceCubes : IBlendable
    {
        /// Blends the ice cubes
        /// </summary>
        /// <returns>The result of blending the ice cubes</returns>
        public string Blend()
        {
            return "Little chips of frozen water";
        }
    }
}
