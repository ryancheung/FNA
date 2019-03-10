namespace Microsoft.Xna.Framework
{
    public partial struct Point
    {
        /// <summary>
        /// Gets a <see cref="Vector2"/> representation for this object.
        /// </summary>
        /// <returns>A <see cref="Vector2"/> representation for this object.</returns>
        public Vector2 ToVector2()
        {
            return new Vector2(X, Y);
        }
    }
}
