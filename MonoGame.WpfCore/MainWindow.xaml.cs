using System.Windows;
using System.Windows.Input;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.WpfCore.MonoGameControls;

namespace MonoGame.WpfCore
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private SpriteBatch _spriteBatch;
        private Texture2D _texture;
        private Vector2 _position = new Vector2(100, 100);

        private void OnGraphicsControlLoadContent(object sender, GraphicsDeviceEventArgs e)
        {

        }

        private void OnGraphicsControlDraw(object sender, DrawEventArgs e)
        {
            if (_texture == null)
            {
                _spriteBatch = new SpriteBatch(e.GraphicsDevice);

                // TODO: This texture never gets disposed.
                _texture = new Texture2D(e.GraphicsDevice, 1, 1);
                _texture.SetData(new[] { Color.White });
            }

            e.GraphicsDevice.Clear(Color.Black);

            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture, _position, Color.White);
            _spriteBatch.End();
        }

        private void DrawingSurface_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void OnGraphicsControlMouseMove(object sender, MouseEventArgs e)
        {
            var position = Mouse.GetPosition(DrawingSurface);
            _position = new Vector2((float)position.X, (float)position.Y);
        }

        private void DrawingSurface_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
        }

        private void DrawingSurface_OnMouseUp(object sender, MouseButtonEventArgs e)
        {
        }

        private void DrawingSurface_OnMouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void OnGraphicsControlHwndMouseWheel(object sender, MouseWheelEventArgs e)
        {
        }

        private void OnGraphicsControlKeyDown(object sender, KeyEventArgs e)
        {
        }

        private void OnGraphicsControlKeyUp(object sender, KeyEventArgs e)
        {
        }
    }
}
