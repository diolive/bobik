using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Back : Subject
    {
        public Back()
            : base(new Sprite(AssetStorage.Textures.Back) { Origin = Vector2.Zero }, true)
        {
            Z = -float.MaxValue;
        }
    }
}