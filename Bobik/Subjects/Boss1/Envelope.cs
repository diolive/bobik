using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Boss1
{
    public class Envelope : Subject
    {
        public Envelope()
            : base(new Sprite(AssetStorage.Textures.Boss1.Envelope), new Vector2(567,400))
        {
        }
    }
}