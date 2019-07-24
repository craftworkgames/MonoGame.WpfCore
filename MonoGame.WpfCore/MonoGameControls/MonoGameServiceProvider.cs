using System;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame.WpfCore.MonoGameControls
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