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
            Fonts.Load();
            Textures.Load();
        }

        public static class Fonts
        {
            public static SpriteFont Primary { get; private set; }

            public static void Load()
            {
                Primary = _contentManager.Load<SpriteFont>("Fonts/Primary");
            }
        }

        public static class Textures
        {
            public static Texture2D Sheet { get; private set; }
            public static Texture2D BobikMain { get; private set; }
            public static Texture2D BobikIdle { get; private set; }
            public static Texture2D BobikWalk { get; private set; }
            public static Texture2D BobikStatic { get; private set; }
            public static Texture2D AtomRavus { get; private set; }
            public static Texture2D AtomDusya { get; private set; }
            public static Texture2D AtomDio { get; private set; }
            public static Texture2D Eggs { get; private set; }
            public static Texture2D Sheet1 { get; private set; }
            public static Texture2D Cloud1 { get; private set; }
            public static Texture2D Cloud2 { get; private set; }
            public static Texture2D Cloud3 { get; private set; }
            public static Texture2D[] Front { get; private set; }
            public static Texture2D[] Middle { get; private set; }
            public static Texture2D[] Back { get; private set; }
            public static Texture2D[] Ground { get; private set; }
            public static Texture2D LetterA { get; private set; }
            public static Texture2D LetterB { get; private set; }
            public static Texture2D LetterC { get; private set; }
            public static Texture2D LetterD { get; private set; }
            public static Texture2D Platform { get; private set; }

            public static void Load()
            {
                Sheet = _contentManager.Load<Texture2D>("Textures/sheet");
                BobikMain = _contentManager.Load<Texture2D>("Textures/bobik_main");
                BobikIdle = _contentManager.Load<Texture2D>("Textures/bobik_idle");
                BobikWalk = _contentManager.Load<Texture2D>("Textures/bobik_walk");
                BobikStatic = _contentManager.Load<Texture2D>("Textures/bobik_static");
                AtomRavus = _contentManager.Load<Texture2D>("Textures/atom_ravus");
                AtomDusya = _contentManager.Load<Texture2D>("Textures/atom_dusya");
                AtomDio = _contentManager.Load<Texture2D>("Textures/atom_dio");
                Eggs = _contentManager.Load<Texture2D>("Textures/eggs");
                Sheet1 = _contentManager.Load<Texture2D>("Textures/sheet1");
                Cloud1 = _contentManager.Load<Texture2D>("Textures/cloud_1");
                Cloud2 = _contentManager.Load<Texture2D>("Textures/cloud_2");
                Cloud3 = _contentManager.Load<Texture2D>("Textures/cloud_3");
                Front = Enumerable.Range(1, 5)
                    .Select(index => _contentManager.Load<Texture2D>($"Textures/front_{index}"))
                    .ToArray();
                Middle = Enumerable.Range(1, 5)
                    .Select(index => _contentManager.Load<Texture2D>($"Textures/middle_{index}"))
                    .ToArray();
                Back = Enumerable.Range(1, 5)
                    .Select(index => _contentManager.Load<Texture2D>($"Textures/back_{index}"))
                    .ToArray();
                Ground = Enumerable.Range(1, 5)
                    .Select(index => _contentManager.Load<Texture2D>($"Textures/ground_{index}"))
                    .ToArray();
                LetterA = _contentManager.Load<Texture2D>("Textures/letter_a");
                LetterB = _contentManager.Load<Texture2D>("Textures/letter_b");
                LetterC = _contentManager.Load<Texture2D>("Textures/letter_c");
                LetterD = _contentManager.Load<Texture2D>("Textures/letter_d");
                Platform = _contentManager.Load<Texture2D>("Textures/platform");
            }
        }
    }
}