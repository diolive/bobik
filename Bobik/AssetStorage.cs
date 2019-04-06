using System.Linq;

using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace Bobik
{
    public static class AssetStorage
    {
        private static ContentManager _contentManager;

        public static void LoadAssets(ContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public static class Fonts
        {
            public static SpriteFont Primary { get; } = Load("Primary");

            private static SpriteFont Load(string name)
            {
                return _contentManager.Load<SpriteFont>($"Fonts/{name}");
            }
        }

        public static class Textures
        {
            public static Texture2D BobikMain { get; } = Load("bobik_main");
            public static Texture2D BobikStatic { get; } = Load("bobik_static");

            private static Texture2D Load(string name)
            {
                return _contentManager.Load<Texture2D>($"Textures/{name}");
            }

            public static class Atoms
            {
                public static Texture2D Sheet { get; } = Load("sheet");
                public static Texture2D AtomRavus { get; } = Load("atom_ravus");
                public static Texture2D AtomDusya { get; } = Load("atom_dusya");
                public static Texture2D AtomDio { get; } = Load("atom_dio");
                public static Texture2D Eggs { get; } = Load("eggs");

                private static Texture2D Load(string name)
                {
                    return Textures.Load($"Atoms/{name}");
                }
            }

            public static class Level1
            {
                public static Texture2D BobikIdle { get; } = Load("bobik_idle");
                public static Texture2D BobikWalk { get; } = Load("bobik_walk");
                public static Texture2D Sheet { get; } = Load("sheet");
                public static Texture2D Cloud1 { get; } = Load("cloud_1");
                public static Texture2D Cloud2 { get; } = Load("cloud_2");
                public static Texture2D Cloud3 { get; } = Load("cloud_3");
                public static Texture2D[] Front { get; } = Load("front", 5);
                public static Texture2D[] Middle { get; } = Load("middle", 5);
                public static Texture2D[] Back { get; } = Load("back", 5);
                public static Texture2D[] Ground { get; } = Load("ground", 5);
                public static Texture2D LetterA { get; } = Load("letter_a");
                public static Texture2D LetterB { get; } = Load("letter_b");
                public static Texture2D LetterC { get; } = Load("letter_c");
                public static Texture2D LetterD { get; } = Load("letter_d");
                public static Texture2D Platform { get; } = Load("platform");

                private static Texture2D Load(string name)
                {
                    return Textures.Load($"Level1/{name}");
                }

                private static Texture2D[] Load(string name, int count)
                {
                    return Enumerable.Range(1, count)
                        .Select(index => Load($"{name}_{index}"))
                        .ToArray();
                }
            }
        }
    }
}