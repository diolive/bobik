using System;

using Bobik.Subjects.Common;
using Bobik.Subjects.Menu;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public class MenuScene : Scene
    {
        private readonly Begin _begin;
        private readonly Cards _cards;
        private readonly Welcome _welcome;
        private readonly Zemfira _zemfira;

        public MenuScene(Action<Scene> setScene)
            : base(setScene)
        {
            ShowCursor = true;

            Subjects.Add(new Background());
            Subjects.Add(new BobikMain { Position = new Vector2(500, 300) });
            Subjects.Add(_zemfira = new Zemfira());
            Subjects.Add(_begin = new Begin());
            Subjects.Add(_cards = new Cards());
            Subjects.Add(_welcome = new Welcome());
        }

        public override void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();

            if (!_zemfira.Shown && _cards.IsHovered(mouseState.Position))
            {
                _zemfira.Show();
            }

            if (mouseState.LeftButton == ButtonState.Pressed)
            {
                if (_begin.IsHovered(mouseState.Position))
                {
                    SetScene(new Level1Scene(SetScene));
                    return;
                }
            }

            base.Update(gameTime);
        }
    }
}