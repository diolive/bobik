using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly RepeatMode _repeatMode;
        private readonly Dictionary<SubjectState, Sprite> _sprites;

        public Subject(Sprite sprite, Vector2 position, RepeatMode repeatMode = RepeatMode.None)
        {
            _repeatMode = repeatMode;
            _sprites = new Dictionary<SubjectState, Sprite>
            {
                [SubjectState.Idle] = sprite
            };
            State = SubjectState.Idle;
            Position = position;
            Scale = Vector2.One;
        }

        public Subject(Sprite sprite, RepeatMode repeatMode = RepeatMode.None)
            : this(sprite, Vector2.Zero, repeatMode)
        {
        }

        public SubjectState State { get; set; }

        private Sprite CurrentSprite => _sprites[State];

        public float Z { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public bool HFlipped { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public Vector2 DisplayedPosition => GetDisplayedPosition(Position);

        public void AddState(SubjectState state, Sprite sprite)
        {
            _sprites.Add(state, sprite);
        }

        public Vector2 GetDisplayedPosition(Vector2 position)
        {
            return position - Camera.Position * (float)Math.Pow(0.9, -Z);
        }

        public Vector2 GetDisplayedPosition(float x, float y)
        {
            return GetDisplayedPosition(new Vector2(x, y));
        }

        public virtual void Update(GameTime gameTime)
        {
            CurrentSprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            float y = Position.Y;

            while (y < AppSettings.General.WindowHeight)
            {
                float x = Position.X;
                while (x < AppSettings.General.WindowWidth)
                {
                    Draw(spriteBatch, GetDisplayedPosition(x, y));
                    if (!_repeatMode.HasFlag(RepeatMode.Horizontal)) break;

                    x += CurrentSprite.FrameWidth;
                }

                if (!_repeatMode.HasFlag(RepeatMode.Vertical)) break;

                y += CurrentSprite.FrameHeight;
            }
        }

        private void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(
                CurrentSprite.Texture,
                position,
                CurrentSprite.BoundingRectangle,
                TintColor,
                0f,
                CurrentSprite.Origin,
                Scale,
                HFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
                0f);
        }

        public override string ToString()
        {
            return Position + " : " + DisplayedPosition;
        }
    }
}