using System;
using System.Linq;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public class LevelScene : Scene
    {
        private readonly int _levelWidth;

        public LevelScene(Action<Scene> setScene, int levelWidth)
            : base(setScene)
        {
            _levelWidth = levelWidth;
            Subjects.Add(new Subjects.Level1.Bobik());
        }

        private Subjects.Level1.Bobik TheBobik => Subjects.OfType<Subjects.Level1.Bobik>().Single();

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            var elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                float xDelta = elapsed * AppSettings.Physics.BobikVelocity;
                TheBobik.Position -= new Vector2(xDelta, 0);
                TheBobik.HFlipped = true;
                TheBobik.State = SubjectState.Walk;
                if (TheBobik.DisplayPosition.X < AppSettings.General.CameraGap)
                {
                    Camera.X = Math.Max(0, Camera.X - elapsed * AppSettings.Physics.BobikVelocity);
                }
            }
            else if (keyboardState.IsKeyDown(Keys.Right))
            {
                TheBobik.Position += new Vector2(elapsed * AppSettings.Physics.BobikVelocity, 0);
                TheBobik.HFlipped = false;
                TheBobik.State = SubjectState.Walk;
                if (TheBobik.DisplayPosition.X > AppSettings.General.WindowWidth - AppSettings.General.CameraGap)
                {
                    Camera.X = Math.Min(_levelWidth - AppSettings.General.WindowWidth,
                        Camera.X + elapsed * AppSettings.Physics.BobikVelocity);
                }
            }
            else
            {
                TheBobik.State = SubjectState.Idle;
            }

            if (keyboardState.IsKeyDown(Keys.Space))
            {
                TheBobik.Jump();
            }

            base.Update(gameTime);
        }
    }
}