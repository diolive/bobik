﻿using System;

using Microsoft.Xna.Framework;

namespace Bobik
{
    public class Rotating3DSubject : Subject
    {
        private const float Pi2 = (float)(Math.PI * 2);
        private readonly Vector2 _initialPosition;
        private TimeSpan _elapsed;

        public Rotating3DSubject(Sprite sprite, Vector2 initialPosition, TimeSpan rotationPeriod, float pathWidth,
                                 float pathHeight, float pathRotation, float phase)
            : base(sprite, initialPosition)
        {
            _initialPosition = initialPosition;
            RotationPeriod = rotationPeriod;
            PathWidth = pathWidth;
            PathHeight = pathHeight;
            PathRotation = pathRotation;
            Phase = phase;
        }

        public TimeSpan RotationPeriod { get; set; }
        public float PathWidth { get; set; }
        public float PathHeight { get; set; }
        public float PathRotation { get; set; }
        public float Phase { get; set; }

        public override void Update(GameTime gameTime)
        {
            _elapsed += gameTime.ElapsedGameTime;

            while (_elapsed >= RotationPeriod)
            {
                _elapsed -= RotationPeriod;
            }

            var angle = (float)(_elapsed.TotalMilliseconds / RotationPeriod.TotalMilliseconds * Pi2);
            Position = _initialPosition + new Vector2(
                           (float)(PathWidth * Math.Cos(angle + Phase)),
                           (float)(PathHeight * Math.Sin(angle + Phase + PathRotation)));
            Scale = Vector2.One * (float)(Math.Sin(angle)/2f + 0.7f);
            Z = (float)Math.Sin(angle);

            base.Update(gameTime);
        }
    }
}