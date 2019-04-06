using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Sheet1 : Subject
    {
        public Sheet1()
            : base(new Sprite(AssetStorage.Textures.Sheet1) { Origin = Vector2.Zero }, RepeatMode.Horizontal)
        {
            Z = -10;
        }
    }
}