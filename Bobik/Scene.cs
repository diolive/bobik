using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public class Scene
    {
        public ICollection<Subject> Subjects { get; } = new List<Subject>();

        public void Update(GameTime gameTime)
        {
            foreach (Subject subject in Subjects)
            {
                subject.Update(gameTime);
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.DrawString(AssetStorage.Fonts.Primary, "test string", new Vector2(50, 100), Color.White);
            foreach (Subject subject in Subjects)
            {
                subject.Draw(spriteBatch);
            }
        }
    }
}