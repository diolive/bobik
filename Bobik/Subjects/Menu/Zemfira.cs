using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Menu
{
    public class Zemfira : Subject
    {
        private bool _showInProgress;

        public Zemfira()
            : base(new Sprite(AssetStorage.Textures.Menu.Zemfira), new Vector2(-185, 220))
        {
        }

        public bool Shown { get; private set; }

        public void Show()
        {
            Shown = true;
            _showInProgress = true;
        }

        public override void Update(GameTime gameTime)
        {
            if (_showInProgress)
            {
                float x = Position.X + (float)(gameTime.ElapsedGameTime.TotalMilliseconds * 0.2f);
                if (x >= 250)
                {
                    x = 250;
                    _showInProgress = false;
                }

                Position = new Vector2(x, Position.Y);
            }

            base.Update(gameTime);
        }
    }
}