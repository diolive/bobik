using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Ground : Subject
    {
        public Ground(int index)
            : base(new Sprite(AssetStorage.Textures.Ground[index]) { Origin = Vector2.Zero },
                new Vector2(index * 800, 464))
        {
        }
    }
}