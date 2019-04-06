namespace Bobik.Subjects.Atoms
{
    public class AtomDusya : Rotating3DSubject
    {
        public AtomDusya()
            : base(new Sprite(AssetStorage.Textures.Atoms.AtomDusya),
                AppSettings.General.ScreenCenter,
                AppSettings.Atoms.AtomDusyaRotationPeriod,
                AppSettings.Atoms.AtomDusyaPathWidth,
                AppSettings.Atoms.AtomDusyaPathHeight,
                AppSettings.Atoms.AtomDusyaPathRotation,
                AppSettings.Atoms.AtomDusyaPhase)
        {
        }
    }
}