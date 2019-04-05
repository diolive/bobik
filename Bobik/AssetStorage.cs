using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public static class AssetStorage
    {
        public static void LoadAssets(ContentManager contentManager)
        {
            Fonts.LoadAssets(contentManager);
            Textures.LoadAssets(contentManager);
        }

        public static class Fonts
        {
            public static SpriteFont Primary { get; private set; }

            public static void LoadAssets(ContentManager contentManager)
            {
                Primary = contentManager.Load<SpriteFont>("Fonts/Primary");
            }
        }

        public static class Textures
        {
            public static Texture2D Sheet { get; private set; }
            public static Texture2D Bobik { get; private set; }
            public static Texture2D AtomRavus { get; private set; }
            public static Texture2D AtomDusya { get; private set; }

            public static void LoadAssets(ContentManager contentManager)
            {
                Sheet = contentManager.Load<Texture2D>("Textures/sheet");
                Bobik = contentManager.Load<Texture2D>("Textures/bobik");
                AtomRavus = contentManager.Load<Texture2D>("Textures/atom_ravus");
                AtomDusya = contentManager.Load<Texture2D>("Textures/atom_dusya");
            }
        }
    }
}