using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Sprite
    {
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
            FrameWidth = texture.Width / _frameXCount;
            FrameHeight = texture.Height / _frameYCount;
            Origin = new Vector2(FrameWidth, FrameHeight) / 2;

            _timeToFrame = TimeSpan.FromMilliseconds(60);
        }

        public Vector2 Origin { get; set; }

        public int FrameWidth { get; }
        public int FrameHeight { get; }

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

        public void Draw(SpriteBatch spriteBatch, Vector2 position, bool hFlipped, Color tintColor, Vector2 scale)
        {
            int xIndex = _currentFrame % _frameXCount;
            int yIndex = _currentFrame / _frameXCount;

            SpriteEffects effects = hFlipped
                ? SpriteEffects.FlipHorizontally
                : SpriteEffects.None;

            spriteBatch.Draw(
                _texture,
                position - Camera.Position,
                new Rectangle(xIndex * FrameWidth, yIndex * FrameHeight, FrameWidth, FrameHeight),
                tintColor,
                0f,
                Origin,
                scale,
                effects,
                0f);
        }
    }
}