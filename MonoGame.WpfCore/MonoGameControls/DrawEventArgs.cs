using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.WpfCore.MonoGameControls
{
    public sealed class DrawEventArgs : GraphicsDeviceEventArgs
    {
        private readonly MonoGameDrawingSurface _drawingSurface;

        public DrawEventArgs(MonoGameDrawingSurface drawingSurface, IGraphicsDeviceService graphicsDeviceService)
            : base(graphicsDeviceService)
        {
            _drawingSurface = drawingSurface;
        }

        public void InvalidateSurface()
        {
            _drawingSurface.Invalidate();
        }
    }
}
