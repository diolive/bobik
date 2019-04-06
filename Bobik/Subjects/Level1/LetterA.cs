namespace Bobik.Subjects.Level1
{
    public class LetterA : Subject
    {
        public LetterA()
            : base(new Sprite(AssetStorage.Textures.LetterA), AppSettings.General.ScreenCenter)
        {
        }
    }
}