namespace Bobik.Subjects.Menu
{
    public class Sheet : Subject
    {
        public Sheet()
            : base(new Sprite(AssetStorage.Textures.Sheet), AppSettings.General.ScreenCenter)
        {
            Z = -10;
        }
    }
}