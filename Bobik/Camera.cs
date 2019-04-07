using Microsoft.Xna.Framework;

namespace Bobik
{
    public static class Camera
    {
        public static float X { get; set; }

        public static float Y { get; set; }

        public static Vector2 Position
        {
            get => new Vector2(X, Y);
            set
            {
                X = value.X;
                Y = value.Y;
            }
        }

        public static Rectangle Viewport =>
            new Rectangle((int)X, (int)Y, AppSettings.General.WindowWidth, AppSettings.General.WindowHeight);

        public static void Reset()
        {
            Position = Vector2.Zero;
        }
    }
}