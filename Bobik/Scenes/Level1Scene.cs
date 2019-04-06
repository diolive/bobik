using System;

using Bobik.Subjects.Level1;

namespace Bobik.Scenes
{
    public class Level1Scene : LevelScene
    {
        public Level1Scene(Action<Scene> setScene)
            : base(setScene, 2500)
        {
            Subjects.Add(new Back());
            Subjects.Add(new Cloud1());
            Subjects.Add(new Cloud2());
            Subjects.Add(new Cloud3());
            //Subjects.Add(new Fon1());
            //Subjects.Add(new Fon2());
            //Subjects.Add(new Fon3());
            //Subjects.Add(new Ground());
            Subjects.Add(new LetterA());
            Subjects.Add(new LetterB());
            Subjects.Add(new LetterC());
            Subjects.Add(new LetterD());
            Subjects.Add(new Platform());
        }
    }
}