using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik.Subjects.Level1
{
    public class Cloud : Subject
    {
        public enum Types
        {
            Type1,
            Type2,
            Type3
        }

        public Cloud(Types type, Vector2 position)
            : base(new Sprite(GetTexture(type)), position)
        {
        }

        private static Texture2D GetTexture(Types type)
        {
            switch (type)
            {
                default:
                case Types.Type1:
                    return AssetStorage.Textures.Level1.Cloud1;

                case Types.Type2:
                    return AssetStorage.Textures.Level1.Cloud2;

                case Types.Type3:
                    return AssetStorage.Textures.Level1.Cloud3;
            }
        }
    }
}