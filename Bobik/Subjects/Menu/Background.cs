using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Menu
{
    public class Background : Subject
    {
        public Background()
            : base(new Sprite(AssetStorage.Textures.Menu.Background) { Origin = Vector2.Zero })
        {
        }
    }
}