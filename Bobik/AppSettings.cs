﻿using System;

using Microsoft.Xna.Framework;

namespace Bobik
{
    public static class AppSettings
    {
        public static class General
        {
            public const int WindowWidth = 1800;
            public const int WindowHeight = 800;
            public const int CameraGap = 450;
            public static Vector2 ScreenCenter { get; } = new Vector2(WindowWidth, WindowHeight) / 2;
        }

        public static class Physics
        {
            public const float BobikVelocity = 0.64f;
            public const float JumpVelocity = 1.0f;
            public const float Gravity = 0.003f;
        }

        public static class Atoms
        {
            public const float AtomRavusPathWidth = 400f;
            public const float AtomRavusPathHeight = 200f;
            public const float AtomRavusPathRotation = (float)(Math.PI / 3);
            public const float AtomRavusPhase = 0f;

            public const float AtomDusyaPathWidth = -400f;
            public const float AtomDusyaPathHeight = 200f;
            public const float AtomDusyaPathRotation = (float)(Math.PI / 3);
            public const float AtomDusyaPhase = (float)(Math.PI / 3);

            public const float AtomDioPathWidth = 100f;
            public const float AtomDioPathHeight = 300f;
            public const float AtomDioPathRotation = (float)(Math.PI / 3);
            public const float AtomDioPhase = (float)(Math.PI * 2 / 3);

            public const float RotationScaleMultiplier = 0.5f;
            public const float RotationScaleBase = 0.7f;
            public static TimeSpan AtomRavusRotationPeriod { get; } = TimeSpan.FromSeconds(4);
            public static TimeSpan AtomDusyaRotationPeriod { get; } = TimeSpan.FromSeconds(4);
            public static TimeSpan AtomDioRotationPeriod { get; } = TimeSpan.FromSeconds(4);
        }

        public static class Level1
        {
            public static Vector2 BobikInitialPosition { get; } = new Vector2(700, 430);
        }

        public static class Boss1
        {
            public const string Answer = "585";
        }
    }
}