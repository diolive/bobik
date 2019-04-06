using System;

using Microsoft.Xna.Framework;

namespace Bobik
{
    public class Rotating3DSubject : Subject
    {
        private readonly Vector2 _position;
        private TimeSpan _elapsed;

        public Rotating3DSubject(Sprite sprite, Vector2 position, TimeSpan rotationPeriod, float pathWidth,
                                 float pathHeight, float pathRotation, float phase)
            : base(sprite, position)
        {
            _position = position;
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

            var angle = (float)(_elapsed.TotalMilliseconds / RotationPeriod.TotalMilliseconds * Math.PI * 2);
            Position = _position + new Vector2(
                           (float)(PathWidth * Math.Cos(angle + Phase)),
                           (float)(PathHeight * Math.Sin(angle + Phase + PathRotation)));
            Scale = Vector2.One *
                    (float)(Math.Sin(angle + Phase) * AppSettings.Atoms.RotationScaleMultiplier +
                            AppSettings.Atoms.RotationScaleBase);
            Z = (float)Math.Sin(angle);

            base.Update(gameTime);
        }
    }
}