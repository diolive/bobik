namespace Bobik.Subjects.Atoms
{
    public class AtomRavus : Rotating3DSubject
    {
        public AtomRavus()
            : base(new Sprite(AssetStorage.Textures.Atoms.AtomRavus),
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