using Microsoft.Xna.Framework.Graphics;

namespace MonoGameOnWpfCore.MonoGame
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
