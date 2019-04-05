using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Sprite
    {
        private readonly int _frameHeight;
        private readonly int _frameWidth;
        private readonly int _frameXCount;
        private readonly int _frameYCount;
        private readonly Texture2D _texture;

        private readonly TimeSpan _timeToFrame;

        private int _currentFrame;
        private TimeSpan _frameElapsed;

        public Sprite(Texture2D texture, int frameXCount = 1, int frameYCount = 1)
        {
            _texture = texture;
            _frameXCount = frameXCount;
            _frameYCount = frameYCount;
            _frameWidth = texture.Width / _frameXCount;
            _frameHeight = texture.Height / _frameYCount;

            _timeToFrame = TimeSpan.FromMilliseconds(60);
        }

        public void Update(GameTime gameTime)
        {
            _frameElapsed += gameTime.ElapsedGameTime;
            if (_frameElapsed >= _timeToFrame)
            {
                _frameElapsed -= _timeToFrame;
                _currentFrame++;
                if (_currentFrame == _frameXCount * _frameYCount)
                {
                    _currentFrame = 0;
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position, bool hFlipped)
        {
            int xIndex = _currentFrame % _frameXCount;
            int yIndex = _currentFrame / _frameXCount;

            SpriteEffects effects = hFlipped
                ? SpriteEffects.FlipHorizontally
                : SpriteEffects.None;

            spriteBatch.Draw(
                _texture,
                position,
                new Rectangle(xIndex * _frameWidth, yIndex * _frameHeight, _frameWidth, _frameHeight),
                Color.White,
                0f,
                Vector2.Zero,
                Vector2.One,
                effects,
                0f);
        }
    }
}