using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public static class AssetStorage
    {
        public static void LoadAssets(ContentManager contentManager)
        {
            Fonts.LoadAssets(contentManager);
        }

        public static class Fonts
        {
            public static SpriteFont Primary { get; private set; }

            public static void LoadAssets(ContentManager contentManager)
            {
                Primary = contentManager.Load<SpriteFont>("Fonts/Primary");
            }
        }
    }
}