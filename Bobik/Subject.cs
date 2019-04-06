﻿using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Subject
    {
        private readonly Dictionary<SubjectState, Sprite> _sprites;
        private readonly bool _tile;

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

        public Subject(Sprite sprite, bool tile)
            : this(sprite, Vector2.Zero)
        {
            _tile = tile;
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
            if (_tile)
            {
                float y = Position.Y;

                while (y < AppSettings.General.WindowHeight)
                {
                    float x = Position.X;
                    while (x < AppSettings.General.WindowWidth)
                    {
                        spriteBatch.Draw(
                            CurrentSprite.Texture,
                            GetDisplayedPosition(x, y),
                            CurrentSprite.BoundingRectangle,
                            TintColor,
                            0f,
                            CurrentSprite.Origin,
                            Scale,
                            HFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
                            0f);
                        x += CurrentSprite.FrameWidth;
                    }

                    y += CurrentSprite.FrameHeight;
                }
            }
            else
            {
                spriteBatch.Draw(
                    CurrentSprite.Texture,
                    DisplayedPosition,
                    CurrentSprite.BoundingRectangle,
                    TintColor,
                    0f,
                    CurrentSprite.Origin,
                    Scale,
                    HFlipped ? SpriteEffects.FlipHorizontally : SpriteEffects.None,
                    0f);
            }
        }

        public override string ToString()
        {
            return Position + " : " + DisplayedPosition;
        }
    }
}