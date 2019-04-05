﻿namespace Bobik.Subjects
{
    public class Sheet : Subject
    {
        public Sheet()
            : base(new Sprite(AssetStorage.Textures.Sheet), AppSettings.ScreenCenter)
        {
            Z = -float.MaxValue;
        }
    }
}