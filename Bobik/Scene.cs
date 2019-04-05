using System;
using System.Collections.Generic;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

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
        }
    }
}