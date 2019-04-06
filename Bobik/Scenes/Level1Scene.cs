using System;

using Bobik.Subjects.Level1;

namespace Bobik.Scenes
{
    public class Level1Scene : LevelScene
    {
        public Level1Scene(Action<Scene> setScene)
            : base(setScene, 8000)
        {
            for (var i = 0; i < 10; i++)
            {
                Subjects.Add(new Sheet(i));
            }

            //Subjects.Add(new Cloud1());
            //Subjects.Add(new Cloud2());
            //Subjects.Add(new Cloud3());

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
    }
}