using System;
using System.Text;

using Bobik.Subjects.Boss1;
using Bobik.Subjects.Common;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public class Boss1Scene : Scene, ITextInputScene
    {
        private readonly BobikMain _bobik;
        private readonly StringBuilder _input = new StringBuilder();

        public Boss1Scene(Action<Scene> setScene)
            : base(setScene)
        {
            Subject subject = null;

            Subjects.Add(new Sheet());
            Subjects.Add(new Corner());
            Subjects.Add(_bobik = new BobikMain { Position = new Vector2(1600, 270) });
            Subjects.Add(new Answer());
            Subjects.Add(new Envelope());
            Subjects.Add(new Left());
            Subjects.Add(new Right());

#if DEBUG
            DebugSubject = subject;
#endif
        }

        public void InputText(char character, Keys key)
        {
            if (key == Keys.Back)
            {
                if (_input.Length > 0)
                {
                    _input.Remove(_input.Length - 1, 1);
                }
            }
            else if (key == Keys.Enter)
            {
                _bobik.TintColor = _input.ToString() == AppSettings.Boss1.Answer ? Color.LightGreen : Color.LightPink;
            }
            else
            {
                _input.Append(character);
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);

            if (_input.Length > 0)
            {
                spriteBatch.DrawString(AssetStorage.Fonts.Answers,
                    _input.ToString(),
                    new Vector2(1270, 600),
                    new Color(20, 20, 20),
                    (float)(Math.PI / 24),
                    Vector2.Zero,
                    1f,
                    SpriteEffects.None,
                    0f);
            }
        }
    }
}