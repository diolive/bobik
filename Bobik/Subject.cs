using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly Sprite _sprite;

        public Subject(Sprite sprite)
        {
            _sprite = sprite;
        }

        public Vector2 Position { get; set; }
        public bool HFlipped { get; set; }
        public float VerticalVelocity { get; set; }
        public float BaseLine { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public event Action Dropped;

        public Subject At(float x, float y)
        {
            return At(new Vector2(x, y));
        }

        public Subject At(Vector2 position)
        {
            Position = position;
            BaseLine = position.Y;
            return this;
        }

        public virtual void Update(GameTime gameTime)
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
            _sprite.Update(gameTime);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch, Position, HFlipped, TintColor);
        }
    }
}