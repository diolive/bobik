namespace Bobik.Subjects.Level1
{
    public class Cloud1 : Subject
    {
        public Cloud1()
            : base(new Sprite(AssetStorage.Textures.Level1.Cloud1), AppSettings.General.ScreenCenter)
        {
        }
    }
}