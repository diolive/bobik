using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Front : Subject
    {
        public Front(int index)
            : base(new Sprite(AssetStorage.Textures.Level1.Front[index]) { Origin = Vector2.Zero },
                new Vector2(index * 1600, 0))
        {
            Z = -4;
        }
    }
}