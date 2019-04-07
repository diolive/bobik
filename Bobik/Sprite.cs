using System;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Sprite
    {
        private readonly int _frameXCount;
        private readonly int _frameYCount;
        private readonly bool _updateable;

        private readonly TimeSpan _timeToFrame;

        private int _currentFrameX;
        private int _currentFrameY;
        private TimeSpan _frameElapsed;

        public Sprite(Texture2D texture, int frameXCount = 1, int frameYCount = 1, double timeToFrame = 60)
        {
            Texture = texture;
            _frameXCount = frameXCount;
            _frameYCount = frameYCount;
            FrameWidth = texture.Width / _frameXCount;
            FrameHeight = texture.Height / _frameYCount;
            Origin = new Vector2(FrameWidth, FrameHeight) / 2;
            _updateable = frameXCount * frameYCount > 1;

            _timeToFrame = TimeSpan.FromMilliseconds(timeToFrame);
        }

        public Texture2D Texture { get; }

        public Vector2 Origin { get; set; }

        public int FrameWidth { get; }
        public int FrameHeight { get; }

        public Rectangle BoundingRectangle =>
            new Rectangle(_currentFrameX * FrameWidth, _currentFrameY * FrameHeight, FrameWidth, FrameHeight);

        public void Update(GameTime gameTime)
        {
            if (!_updateable) return;

            _frameElapsed += gameTime.ElapsedGameTime;
            if (_frameElapsed < _timeToFrame) return;

            _frameElapsed -= _timeToFrame;
            _currentFrameX++;

            if (_currentFrameX < _frameXCount) return;

            _currentFrameX = 0;
            _currentFrameY++;

            if (_currentFrameY == _frameYCount)
            {
                _currentFrameY = 0;
            }
        }
    }
}