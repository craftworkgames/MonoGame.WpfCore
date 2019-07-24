using System;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.WpfCore.MonoGameControls
{
    public class GraphicsDeviceEventArgs : EventArgs
    {
        public GraphicsDeviceEventArgs(IGraphicsDeviceService graphicsDeviceService)
        {
            GraphicsDeviceService = graphicsDeviceService;
        }

        public IGraphicsDeviceService GraphicsDeviceService { get; }
        public GraphicsDevice GraphicsDevice => GraphicsDeviceService.GraphicsDevice;
    }
}