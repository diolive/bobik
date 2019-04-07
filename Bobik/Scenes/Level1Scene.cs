using System;
using System.Collections.Generic;

using Bobik.Subjects.Level1;

using Microsoft.Xna.Framework;

namespace Bobik.Scenes
{
    public class Level1Scene : LevelScene
    {
        private readonly List<Cloud> _clouds = new List<Cloud>();

        public Level1Scene(Action<Scene> setScene)
            : base(setScene, 8000)
        {
            for (var i = 0; i < 10; i++)
            {
                Subjects.Add(new Sheet(i));
            }

            Subjects.Add(new Cloud(Cloud.Types.Type1, new Vector2(600, 200)));
            Subjects.Add(new Cloud(Cloud.Types.Type2, new Vector2(3600, 200)));
            var cloud3 = new Cloud(Cloud.Types.Type3, new Vector2(6600, 200));
            Subjects.Add(cloud3);
            _clouds.Add(cloud3);

            for (var i = 0; i < 5; i++)
            {
                Subjects.Add(new Back(i));
                Subjects.Add(new Middle(i));
                Subjects.Add(new Front(i));
                Subjects.Add(new Ground(i));
            }

            //Subjects.Add(new LetterA());
            //Subjects.Add(new LetterB());
            //Subjects.Add(new LetterC());
            //Subjects.Add(new LetterD());
            //Subjects.Add(new Platform());
        }

        public override void Update(GameTime gameTime)
        {
            foreach (Cloud cloud in _clouds)
            {
                cloud.HFlipped = TheBobik.Position.X > 6000;
            }

            if (TheBobik.Position.X >= 8000)
            {
                SetScene(new Boss1Scene(SetScene));
                return;
            }

            base.Update(gameTime);
        }
    }
}