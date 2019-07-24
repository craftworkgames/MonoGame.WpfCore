using System;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGameOnWpfCore.MonoGame
{
    public class MonoGameServiceProvider : IServiceProvider
    {
        private readonly IGraphicsDeviceService _graphicsDeviceService;

        public MonoGameServiceProvider(IGraphicsDeviceService graphicsDeviceService)
        {
            _graphicsDeviceService = graphicsDeviceService;
        }

        public object GetService(Type serviceType)
        {
            return _graphicsDeviceService;
        }
    }
}