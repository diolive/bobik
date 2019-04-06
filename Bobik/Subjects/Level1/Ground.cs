using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Ground : Subject
    {
        public Ground(int index)
            : base(new Sprite(AssetStorage.Textures.Level1.Ground[index]) { Origin = Vector2.Zero },
                new Vector2(index * 1600, 464))
        {
            Z = -0.1f;
        }
    }
}