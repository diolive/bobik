using Microsoft.Xna.Framework;

namespace Bobik
{
    public static class Camera
    {
        public static float X { get; set; }
        public static float Y { get; set; }
        public static Vector2 Position => new Vector2(X, Y);
        public static Rectangle Viewport =>
            new Rectangle((int)X, (int)Y, AppSettings.General.WindowWidth, AppSettings.General.WindowHeight);
    }
}