namespace Bobik.Subjects.Level1
{
    public class LetterA : Subject
    {
        public LetterA()
            : base(new Sprite(AssetStorage.Textures.Level1.LetterA), AppSettings.General.ScreenCenter)
        {
        }
    }
}