namespace Microsoft.Xna.Framework.Input
{
    public partial struct MouseState
    {
        /// <summary>
        /// Gets cursor position.
        /// </summary>
        public Point Position
        {
            get { return new Point(X, Y); }   
        }
    }
}
