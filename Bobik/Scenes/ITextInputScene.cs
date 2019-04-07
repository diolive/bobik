using Microsoft.Xna.Framework.Input;

namespace Bobik.Scenes
{
    public interface ITextInputScene
    {
        void InputText(char character, Keys key);
    }
}