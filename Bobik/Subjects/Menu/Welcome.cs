using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Menu
{
    public class Welcome : Subject
    {
        public Welcome()
            : base(new Sprite(AssetStorage.Textures.Menu.Welcome), new Vector2(1300, 600))
        {
        }
    }
}