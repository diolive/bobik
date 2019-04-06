using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Sheet : Subject
    {
        public Sheet(int index)
            : base(new Sprite(AssetStorage.Textures.Level1.Sheet) { Origin = Vector2.Zero },
                new Vector2(index * 800, 0))
        {
            Z = -10;
        }
    }
}