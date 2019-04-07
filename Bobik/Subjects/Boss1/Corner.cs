using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Boss1
{
    public class Corner : Subject
    {
        public Corner()
            : base(new Sprite(AssetStorage.Textures.Boss1.Corner) { Origin = new Vector2(736, 0) },
                new Vector2(1800, 0))
        {
            Z = -10;
        }
    }
}