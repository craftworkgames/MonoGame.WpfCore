using System;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameOnWpfCore.MonoGame
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