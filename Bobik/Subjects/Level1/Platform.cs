namespace Bobik.Subjects.Level1
{
    public class Platform : Subject
    {
        public Platform()
            : base(new Sprite(AssetStorage.Textures.Platform), AppSettings.General.ScreenCenter)
        {
        }
    }
}