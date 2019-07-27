using System;
using System.Windows;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.WpfCore.MonoGameControls;

namespace MonoGame.WpfCore
{
    public class MonoGameViewModel : ViewModel, IMonoGameDrawingSurfaceViewModel
    {
        public IGraphicsDeviceService GraphicsDeviceService { get; set; }
        public GraphicsDevice GraphicsDevice => GraphicsDeviceService?.GraphicsDevice;

        public virtual void Initialize() { }
        public virtual void LoadContent() { }
        public virtual void UnloadContent() { }
        public virtual void Update(GameTime gameTime) { }
        public virtual void Draw(GameTime gameTime) { }
        public virtual void OnActivated(object sender, EventArgs args) { }
        public virtual void OnDeactivated(object sender, EventArgs args) { }
        public virtual void OnExiting(object sender, EventArgs args) { }
        public virtual void SizeChanged(object sender, SizeChangedEventArgs args) { }
    }
}