using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly Sprite _sprite;
        private readonly bool _tile;

        public Subject(Sprite sprite, Vector2 position)
        {
            _sprite = sprite;
            Position = position;
            Scale = Vector2.One;
        }

        public Subject(Sprite sprite, bool tile)
            : this(sprite, Vector2.Zero)
        {
            _tile = tile;
        }

        public float Z { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public bool HFlipped { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public virtual void Update(GameTime gameTime)
        {
            _sprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            if (_tile)
            {
                float y = Position.Y;

                while (y < AppSettings.General.WindowHeight)
                {
                    float x = Position.X;
                    while (x < AppSettings.General.WindowWidth)
                    {
                        _sprite.Draw(spriteBatch, new Vector2(x, y), HFlipped, TintColor, Scale);
                        x += _sprite.FrameWidth;
                    }

                    y += _sprite.FrameHeight;
                }
            }
            else
            {
                _sprite.Draw(spriteBatch, Position, HFlipped, TintColor, Scale);
            }
        }
    }
}