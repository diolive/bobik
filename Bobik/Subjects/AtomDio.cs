namespace Bobik.Subjects
{
    public class AtomDio : Rotating3DSubject
    {
        public AtomDio()
            : base(new Sprite(AssetStorage.Textures.AtomDio),
                AppSettings.ScreenCenter,
                AppSettings.AtomDioRotationPeriod,
                AppSettings.AtomDioPathWidth,
                AppSettings.AtomDioPathHeight,
                AppSettings.AtomDioPathRotation,
                AppSettings.AtomDioPhase)
        {
        }
    }
}