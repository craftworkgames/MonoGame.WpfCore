using System.Windows;
using System.Windows.Input;
using Microsoft.Xna.Framework;
using MonoGameOnWpfCore.MonoGame;

namespace MonoGameOnWpfCore
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnGraphicsControlLoadContent(object sender, GraphicsDeviceEventArgs e)
        {
        }

        private void OnGraphicsControlDraw(object sender, DrawEventArgs e)
        {
            e.GraphicsDevice.Clear(Color.CornflowerBlue);
        }

        private void DrawingSurface_OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void OnGraphicsControlMouseMove(object sender, MouseEventArgs e)
        {
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
