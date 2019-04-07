using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Subjects.Menu
{
    public class Cards : Subject
    {
        public Cards()
            : base(new Sprite(AssetStorage.Textures.Menu.Cards), new Vector2(1300, 450))
        {
        }
    }
}