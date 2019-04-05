using Microsoft.Xna.Framework;

namespace Bobik.Subjects
{
    public class Bobik : Subject
    {
        public Bobik()
            : base(new Sprite(AssetStorage.Textures.Bobik))
        {
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}