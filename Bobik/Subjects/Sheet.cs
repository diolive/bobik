using Microsoft.Xna.Framework;

namespace Bobik.Subjects
{
    public class Sheet : Subject
    {
        public Sheet()
        {
            Sprite = new Sprite(AssetStorage.Textures.Sheet);
            Position = Vector2.Zero;
        }
    }
}