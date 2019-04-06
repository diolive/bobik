namespace Bobik.Subjects.Menu
{
    public class Eggs : Subject
    {
        public Eggs()
            : base(new Sprite(AssetStorage.Textures.Eggs), AppSettings.General.ScreenCenter)
        {
        }
    }
}