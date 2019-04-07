using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Bobik
{
    public class Scene
    {
        public Scene(Action<Scene> setScene)
        {
            SetScene = setScene;
        }

        protected Action<Scene> SetScene { get; }
        public ICollection<Subject> Subjects { get; } = new List<Subject>();
        public bool ShowCursor { get; set; }

        public virtual void Update(GameTime gameTime)
        {
            foreach (Subject subject in Subjects)
            {
                subject.Update(gameTime);
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (Subject subject in Subjects.OrderBy(s => s.Z))
            {
                subject.Draw(spriteBatch);
            }

            if (ShowCursor)
            {
                spriteBatch.Draw(
                    AssetStorage.Textures.Cursor,
                    Mouse.GetState().Position.ToVector2(),
                    null,
                    Color.White,
                    0f,
                    new Vector2(10, 90),
                    1f,
                    SpriteEffects.None,
                    0f);
            }
        }
    }
}