namespace Bobik.Subjects.Atoms
{
    public class Sheet : Subject
    {
        public Sheet()
            : base(new Sprite(AssetStorage.Textures.Atoms.Sheet), AppSettings.General.ScreenCenter)
        {
            Z = -10;
        }
    }
}