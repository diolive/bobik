namespace Bobik.Subjects
{
    public class AtomDusya : Rotating3DSubject
    {
        public AtomDusya()
            : base(new Sprite(AssetStorage.Textures.AtomDusya),
                AppSettings.ScreenCenter,
                AppSettings.AtomDusyaRotationPeriod,
                AppSettings.AtomDusyaPathWidth,
                AppSettings.AtomDusyaPathHeight,
                AppSettings.AtomDusyaPathRotation,
                AppSettings.AtomDusyaPhase)
        {
        }
    }
}