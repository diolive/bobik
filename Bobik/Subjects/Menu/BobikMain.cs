using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Menu
{
    public class BobikMain : Subject
    {
        public BobikMain()
            : base(new Sprite(AssetStorage.Textures.Menu.BobikMain, 9, timeToFrame: 180), new Vector2(500, 300))
        {
        }
    }
}