using System.Linq;
using System.Security.Principal;

using Bobik.Scenes;

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

        private Scene _currentScene;
        private SpriteBatch _spriteBatch;

        public BobikGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        ///     Allows the game to perform any initialization it needs to before starting to run.
        ///     This is where it can query for any required services and load any non-graphic
        ///     related content.  Calling base.Initialize will enumerate through any components
        ///     and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            _graphics.PreferredBackBufferWidth = AppSettings.General.WindowWidth;
            _graphics.PreferredBackBufferHeight = AppSettings.General.WindowHeight;
            _graphics.ApplyChanges();

            base.Initialize();

            Window.TextInput += (s, e) => (_currentScene as ITextInputScene)?.InputText(e.Character, e.Key);
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

            _currentScene = new AtomsScene(SetScene);
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

            _currentScene.Update(gameTime);

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
            _currentScene.Draw(_spriteBatch);

#if DEBUG
            _spriteBatch.DrawString(AssetStorage.Fonts.Debug, $"Camera: {Camera.Position}", new Vector2(10, 10),
                Color.DarkRed);

            if (_currentScene.DebugSubject != null)
            {
                _spriteBatch.DrawString(AssetStorage.Fonts.Debug,
                    $"{_currentScene.DebugSubject.GetType().Name}: {_currentScene.DebugSubject.Position}", new Vector2(10, 40),
                    Color.DarkRed);
            }
#endif

            _spriteBatch.End();

            base.Draw(gameTime);
        }

        private void SetScene(Scene scene)
        {
            _currentScene = scene;
            Camera.Reset();
        }
    }
}