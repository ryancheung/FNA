namespace Microsoft.Xna.Framework
{
    public partial struct Color
    {
        public static implicit operator Color(System.Drawing.Color color)
        {
            return new Color(color.R, color.G, color.B, color.A);
        }

        public static implicit operator System.Drawing.Color(Color color)
        {
            return System.Drawing.Color.FromArgb(color.A, color.R, color.G, color.B);
        }

        public static Color FromArgb(int r, int g, int b)
        {
            return new Color(r, g, b, 255);
        }

        public static Color FromArgb(int a, int r, int g, int b)
        {
            return new Color(r, g, b, a);
        }

        public static Color Empty
        {
            get
            {
                return Color.Transparent;
            }
        }
    }
}
