namespace Bobik.Subjects.Level1
{
    public class Ground : Subject
    {
        public Ground()
            : base(new Sprite(AssetStorage.Textures.Ground), AppSettings.General.ScreenCenter)
        {
        }
    }
}