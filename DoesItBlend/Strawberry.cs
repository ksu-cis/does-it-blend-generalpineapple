using System;
using System.Collections.Generic;
using System.Text;

namespace DoesItBlend
{
    /// <summary>
    /// A class representing a Strawberry
    /// </summary>
    public class Strawberry : Fruit
    {
        /// <summary>
        /// Blends the strawberry
        /// </summary>
        /// <returns>The result of blending a strawberry</returns>
        public override string Blend()
        {
            return "Gooey Red Sweetness";
        }
    }
}
