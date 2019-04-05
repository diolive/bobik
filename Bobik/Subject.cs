using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly Sprite _sprite;

        public Subject(Sprite sprite, Vector2 initialPosition)
        {
            _sprite = sprite;
            Position = initialPosition;
        }

        public Vector2 Position { get; set; }
        public bool HFlipped { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public virtual void Update(GameTime gameTime)
        {
            _sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            _sprite.Draw(spriteBatch, Position, HFlipped, TintColor);
        }
    }
}