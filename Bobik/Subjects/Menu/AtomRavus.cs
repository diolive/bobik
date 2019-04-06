﻿namespace Bobik.Subjects.Menu
{
    public class AtomRavus : Rotating3DSubject
    {
        public AtomRavus()
            : base(new Sprite(AssetStorage.Textures.AtomRavus),
                AppSettings.General.ScreenCenter,
                AppSettings.Atoms.AtomRavusRotationPeriod,
                AppSettings.Atoms.AtomRavusPathWidth,
                AppSettings.Atoms.AtomRavusPathHeight,
                AppSettings.Atoms.AtomRavusPathRotation,
                AppSettings.Atoms.AtomRavusPhase)
        {
        }
    }
}