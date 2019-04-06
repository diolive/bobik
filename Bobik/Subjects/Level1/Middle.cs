using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Middle : Subject
    {
        public Middle(int index)
            : base(new Sprite(AssetStorage.Textures.Middle[index]) { Origin = Vector2.Zero },
                new Vector2(index * 1600, 0))
        {
            Z = -6;
        }
    }
}