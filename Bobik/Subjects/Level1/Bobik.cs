using Microsoft.Xna.Framework;

namespace Bobik.Subjects.Level1
{
    public class Bobik : GravitySubject
    {
        public Bobik()
            : base(new Sprite(AssetStorage.Textures.Bobik1,8), AppSettings.Level1.BobikInitialPosition)
        {
            Dropped += () => IsJumping = false;
        }

        public bool IsJumping { get; private set; }

        public override void Update(GameTime gameTime)
        {
            if (IsJumping)
            {
                VerticalVelocity += (float)gameTime.ElapsedGameTime.TotalMilliseconds * AppSettings.Physics.Gravity;
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
            VerticalVelocity = -AppSettings.Physics.JumpVelocity;
        }
    }
}