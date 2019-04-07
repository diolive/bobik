using System;

using Bobik.Subjects.Atoms;
using Bobik.Subjects.Common;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public class AtomsScene : Scene
    {
        public AtomsScene(Action<Scene> setScene)
            : base(setScene)
        {
            Subjects.Add(new Sheet());
            Subjects.Add(new Eggs());
            Subjects.Add(new AtomRavus());
            Subjects.Add(new AtomDusya());
            Subjects.Add(new AtomDio());
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Space))
            {
                SetScene(new MenuScene(SetScene));
            }

            base.Update(gameTime);
        }
    }
}