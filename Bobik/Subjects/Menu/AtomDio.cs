namespace Bobik.Subjects.Menu
{
    public class AtomDio : Rotating3DSubject
    {
        public AtomDio()
            : base(new Sprite(AssetStorage.Textures.AtomDio),
                AppSettings.General.ScreenCenter,
                AppSettings.Atoms.AtomDioRotationPeriod,
                AppSettings.Atoms.AtomDioPathWidth,
                AppSettings.Atoms.AtomDioPathHeight,
                AppSettings.Atoms.AtomDioPathRotation,
                AppSettings.Atoms.AtomDioPhase)
        {
        }
    }
}