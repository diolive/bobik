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

        public Subject At(float x, float y)
        {
            return At(new Vector2(x, y));
        }

        public Subject At(Vector2 position)
        {
            Position = position;
            return this;
        }

        public virtual void Update(GameTime gameTime)
        {
            _sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch, Position, HFlipped);
        }
    }
}