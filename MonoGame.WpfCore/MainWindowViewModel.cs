using Microsoft.Xna.Framework;

namespace MonoGame.WpfCore
{
    public class MainWindowViewModel : MonoGameViewModel
    {
        public override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
        }
    }
}
