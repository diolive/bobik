namespace Bobik.Subjects.Atoms
{
    public class Eggs : Subject
    {
        public Eggs()
            : base(new Sprite(AssetStorage.Textures.Eggs), AppSettings.General.ScreenCenter)
        {
        }
    }
}