namespace Bobik.Subjects
{
    public class AtomRavus : Rotating3DSubject
    {
        public AtomRavus()
            : base(new Sprite(AssetStorage.Textures.AtomRavus),
                AppSettings.ScreenCenter,
                AppSettings.AtomRavusRotationPeriod,
                AppSettings.AtomRavusPathWidth,
                AppSettings.AtomRavusPathHeight,
                AppSettings.AtomRavusPathRotation,
                AppSettings.AtomRavusPhase)
        {
        }
    }
}