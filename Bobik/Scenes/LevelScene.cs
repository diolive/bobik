using System;
using System.Linq;

using Bobik.Subjects;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public class LevelScene : Scene
    {
        public LevelScene(Action<Scene> setScene)
            : base(setScene)
        {
            Subjects.Add(new Sheet());
            Subjects.Add(new Subjects.Bobik());
        }

        private Subjects.Bobik TheBobik => Subjects.OfType<Subjects.Bobik>().Single();

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            var elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                TheBobik.Position -= new Vector2(elapsed * AppSettings.BobikVelocity, 0);
                TheBobik.HFlipped = true;
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                TheBobik.Position += new Vector2(elapsed * AppSettings.BobikVelocity, 0);
                TheBobik.HFlipped = false;
            }

            if (keyboardState.IsKeyDown(Keys.Space))
            {
                TheBobik.Jump();
            }

            base.Update(gameTime);
        }
    }
}