using System.Linq;

using Bobik.Subjects;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Bobik
{
    /// <summary>
    ///     This is the main type for your game.
    /// </summary>
    public class BobikGame : Game
    {
        private readonly GraphicsDeviceManager _graphics;

        private Scene _gameScene;
        private SpriteBatch _spriteBatch;

        public BobikGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        private Subjects.Bobik TheBobik => _gameScene.Subjects.OfType<Subjects.Bobik>().Single();

        /// <summary>
        ///     Allows the game to perform any initialization it needs to before starting to run.
        ///     This is where it can query for any required services and load any non-graphic
        ///     related content.  Calling base.Initialize will enumerate through any components
        ///     and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = AppSettings.WindowWidth;
            _graphics.PreferredBackBufferHeight = AppSettings.WindowHeight;
            _graphics.ApplyChanges();

            base.Initialize();
        }

        /// <summary>
        ///     LoadContent will be called once per game and is the place to load
        ///     all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            AssetStorage.LoadAssets(Content);

            _gameScene = new Scene();
            _gameScene.Subjects.Add(new Sheet());
            _gameScene.Subjects.Add(new Subjects.Bobik().At(100, 100));
        }

        /// <summary>
        ///     UnloadContent will be called once per game and is the place to unload
        ///     game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        ///     Allows the game to run logic such as updating the world,
        ///     checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            KeyboardState keyboardState = Keyboard.GetState();

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                keyboardState.IsKeyDown(Keys.Escape))
                Exit();

            _gameScene.Update(gameTime);
            var elapsed = (float)gameTime.ElapsedGameTime.TotalMilliseconds;

            if (keyboardState.IsKeyDown(Keys.Left))
            {
                TheBobik.Position -= new Vector2(elapsed * AppSettings.BobikVelocity, 0);
                TheBobik.HFlipped = true;
            }

            if (keyboardState.IsKeyDown(Keys.Right))
            {
                TheBobik.Position += new Vector2(elapsed * AppSettings.BobikVelocity, 0);
                TheBobik.HFlipped = false;
            }

            base.Update(gameTime);
        }

        /// <summary>
        ///     This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            _gameScene.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}