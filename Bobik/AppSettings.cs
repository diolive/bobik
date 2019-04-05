﻿using System;

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
        public const float AtomRavusPathWidth = 400f;
        public const float AtomRavusPathHeight = 200f;
        public const float AtomRavusPathRotation = (float)(Math.PI / 3);
        public const float AtomRavusPhase = 0f;
        public const float AtomDusyaPathWidth = -400f;
        public const float AtomDusyaPathHeight = 200f;
        public const float AtomDusyaPathRotation = (float)(Math.PI / 3);
        public const float AtomDusyaPhase = 0f;

        public static Vector2 ScreenCenter { get; } = new Vector2(WindowWidth, WindowHeight) / 2;
        public static Vector2 BobikInitialPosition { get; } = new Vector2(100, 500);

        public static TimeSpan AtomRavusRotationPeriod { get; } = TimeSpan.FromSeconds(Math.E);
        public static TimeSpan AtomDusyaRotationPeriod { get; } = TimeSpan.FromSeconds(Math.E);
    }
}