using Microsoft.Xna.Framework;

namespace Bobik.Subjects
{
    public class Bobik : Subject
    {
        public Bobik()
        {
            Sprite = new Sprite(AssetStorage.Textures.Bobik);
            Position = new Vector2(100, 100);
        }
    }
}