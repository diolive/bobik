using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Back : Subject
    {
        public Back(int index)
            : base(new Sprite(AssetStorage.Textures.Back[index]) { Origin = Vector2.Zero },
                new Vector2(index * 1600, 0))
        {
            Z = -8;
        }
    }
}