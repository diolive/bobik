using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly Dictionary<SubjectState, Sprite> _sprites;
        private Rectangle _boundingRectangle;
        private Vector2 _previousDisplayPosition;

        public Subject(Sprite sprite, Vector2 position)
        {
            _sprites = new Dictionary<SubjectState, Sprite>
            {
                [SubjectState.Idle] = sprite
            };
            State = SubjectState.Idle;
            Position = position;
            Scale = Vector2.One;
        }

        public Subject(Sprite sprite)
            : this(sprite, Vector2.Zero)
        {
        }

        public SubjectState State { get; set; }

        private Sprite CurrentSprite => _sprites[State];

        public float Z { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Scale { get; set; }
        public bool HFlipped { get; set; }
        public Color TintColor { get; set; } = Color.White;

        public Vector2 DisplayPosition => GetDisplayPosition(Position);
        public Rectangle BoundingRectangle
        {
            get
            {
                Vector2 displayPosition = DisplayPosition;
                if (displayPosition != _previousDisplayPosition)
                {
                    Rectangle rect = CurrentSprite.BoundingRectangle;
                    rect.Offset(Position);
                    rect.Offset(-CurrentSprite.Origin);

                    _boundingRectangle = rect;
                    _previousDisplayPosition = displayPosition;
                }

                return _boundingRectangle;
            }
        }

        public void AddState(SubjectState state, Sprite sprite)
        {
            _sprites.Add(state, sprite);
        }

        public Vector2 GetDisplayPosition(Vector2 position)
        {
            return position - Camera.Position * (float)Math.Pow(0.9, -Z);
        }

        public Vector2 GetDisplayPosition(float x, float y)
        {
            return GetDisplayPosition(new Vector2(x, y));
        }

        public virtual void Update(GameTime gameTime)
        {
            CurrentSprite.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
                CurrentSprite.Texture,
                DisplayPosition,
                CurrentSprite.BoundingRectangle,
                TintColor,
                0f,
                CurrentSprite.Origin,
                Scale,
                HFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
                0f);
        }

        public bool IsHovered(Point point)
        {
            return BoundingRectangle.Contains(point);
        }
    }
}