using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Common
{
    public class BobikMain : Subject
    {
        public BobikMain()
            : base(new Sprite(AssetStorage.Textures.BobikMain, 9, timeToFrame: 180))
        {
        }
    }
}