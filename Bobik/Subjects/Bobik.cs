using Microsoft.Xna.Framework;

namespace Bobik.Subjects
{
    public class Bobik : GravitySubject
    {
        public Bobik()
            : base(new Sprite(AssetStorage.Textures.Bobik1,8), AppSettings.BobikInitialPosition)
        {
            Dropped += () => IsJumping = false;
        }

        public bool IsJumping { get; private set; }

        public override void Update(GameTime gameTime)
        {
            if (IsJumping)
            {
                VerticalVelocity += (float)gameTime.ElapsedGameTime.TotalMilliseconds * AppSettings.Gravity;
            }

            base.Update(gameTime);
        }

        public void Jump()
        {
            if (IsJumping)
            {
                return;
            }

            IsJumping = true;
            VerticalVelocity = -AppSettings.JumpVelocity;
        }
    }
}