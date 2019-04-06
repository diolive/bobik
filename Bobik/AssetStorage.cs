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
            public static Texture2D Bobik1 { get; private set; }
            public static Texture2D AtomRavus { get; private set; }
            public static Texture2D AtomDusya { get; private set; }
            public static Texture2D AtomDio { get; private set; }
            public static Texture2D Eggs { get; private set; }
            public static Texture2D Back { get; private set; }
            public static Texture2D Cloud1 { get; private set; }
            public static Texture2D Cloud2 { get; private set; }
            public static Texture2D Cloud3 { get; private set; }
            public static Texture2D Fon1 { get; private set; }
            public static Texture2D Fon2 { get; private set; }
            public static Texture2D Fon3 { get; private set; }
            public static Texture2D Ground { get; private set; }
            public static Texture2D LetterA { get; private set; }
            public static Texture2D LetterB { get; private set; }
            public static Texture2D LetterC { get; private set; }
            public static Texture2D LetterD { get; private set; }
            public static Texture2D Platform { get; private set; }

            public static void LoadAssets(ContentManager contentManager)
            {
                Sheet = contentManager.Load<Texture2D>("Textures/sheet");
                Bobik = contentManager.Load<Texture2D>("Textures/bobik");
                Bobik1 = contentManager.Load<Texture2D>("Textures/bobik1");
                AtomRavus = contentManager.Load<Texture2D>("Textures/atom_ravus");
                AtomDusya = contentManager.Load<Texture2D>("Textures/atom_dusya");
                AtomDio = contentManager.Load<Texture2D>("Textures/atom_dio");
                Eggs = contentManager.Load<Texture2D>("Textures/eggs");
                Back = contentManager.Load<Texture2D>("Textures/back");
                Cloud1 = contentManager.Load<Texture2D>("Textures/cloud_1");
                Cloud2 = contentManager.Load<Texture2D>("Textures/cloud_2");
                Cloud3 = contentManager.Load<Texture2D>("Textures/cloud_3");
                //Fon1 = contentManager.Load<Texture2D>("Textures/fon_1");
                //Fon2 = contentManager.Load<Texture2D>("Textures/fon_2");
                //Fon3 = contentManager.Load<Texture2D>("Textures/fon_3");
                //Ground = contentManager.Load<Texture2D>("Textures/ground");
                LetterA = contentManager.Load<Texture2D>("Textures/letter_a");
                LetterB = contentManager.Load<Texture2D>("Textures/letter_b");
                LetterC = contentManager.Load<Texture2D>("Textures/letter_c");
                LetterD = contentManager.Load<Texture2D>("Textures/letter_d");
                Platform = contentManager.Load<Texture2D>("Textures/platform");
            }
        }
    }
}