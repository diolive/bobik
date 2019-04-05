using System;

using Microsoft.Xna.Framework;

namespace Bobik
{
    public class GravitySubject : Subject
    {
        public GravitySubject(Sprite sprite, Vector2 position)
            : base(sprite, position)
        {
            BaseLine = position.Y;
        }

        public float VerticalVelocity { get; set; }
        public float BaseLine { get; set; }
        public event Action Dropped;

        public override void Update(GameTime gameTime)
        {
            Vector2 plannedPosition =
                Position + new Vector2(0, VerticalVelocity) * (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (plannedPosition.Y > BaseLine)
            {
                plannedPosition.Y = BaseLine;
                VerticalVelocity = 0f;
                Dropped?.Invoke();
            }

            Position = plannedPosition;
            base.Update(gameTime);
        }
    }
}