using Microsoft.Xna.Framework;

namespace Bobik
{
    public static class AppSettings
    {
        public const int WindowWidth = 1800;
        public const int WindowHeight = 800;

        public const float BobikVelocity = 0.32f;
        public const float JumpVelocity = 1.0f;
        public const float Gravity = 0.003f;
        public static Vector2 BobikInitialPosition { get; } = new Vector2(100, 300);
    }
}