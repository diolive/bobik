using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Menu
{
    public class Begin : Subject
    {
        public Begin()
            : base(new Sprite(AssetStorage.Textures.Menu.Begin), new Vector2(1300, 300))
        {
        }
    }
}