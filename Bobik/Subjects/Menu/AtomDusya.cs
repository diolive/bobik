namespace Bobik.Subjects.Menu
{
    public class AtomDusya : Rotating3DSubject
    {
        public AtomDusya()
            : base(new Sprite(AssetStorage.Textures.AtomDusya),
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