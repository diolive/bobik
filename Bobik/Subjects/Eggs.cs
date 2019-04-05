namespace Bobik.Subjects
{
    public class Eggs : Subject
    {
        public Eggs()
            : base(new Sprite(AssetStorage.Textures.Eggs), AppSettings.ScreenCenter)
        {
        }
    }
}