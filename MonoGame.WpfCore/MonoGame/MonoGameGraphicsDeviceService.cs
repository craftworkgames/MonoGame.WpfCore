using System;
using System.Windows;
using System.Windows.Interop;
using Microsoft.Xna.Framework.Graphics;
using SharpDX.Direct3D9;

namespace MonoGameOnWpfCore.MonoGame
{
    public class MonoGameGraphicsDeviceService : IGraphicsDeviceService, IDisposable
    {
        public Guid InstanceId { get; } = Guid.NewGuid();

        public MonoGameGraphicsDeviceService()
        {
            if (Singleton != null)
                throw new InvalidOperationException($"There can only be one instance of {nameof(MonoGameGraphicsDeviceService)}");

            Singleton = this;
        }

        public static MonoGameGraphicsDeviceService Singleton { get; private set; }

        public Direct3DEx D3DContext { get; private set; }
        public DeviceEx D3DDevice { get; private set; }

        public event EventHandler<EventArgs> DeviceCreated;
        public event EventHandler<EventArgs> DeviceDisposing;
        public event EventHandler<EventArgs> DeviceReset;
        public event EventHandler<EventArgs> DeviceResetting;

        public void StartD3D(Window window)
        {
            D3DContext = new Direct3DEx();

            var presentParameters = new PresentParameters
            {
                Windowed = true,
                SwapEffect = SwapEffect.Discard,
                DeviceWindowHandle = new WindowInteropHelper(window).Handle,
                PresentationInterval = SharpDX.Direct3D9.PresentInterval.Default
            };

            D3DDevice = new DeviceEx(D3DContext, 0, DeviceType.Hardware, IntPtr.Zero,
                CreateFlags.HardwareVertexProcessing | CreateFlags.Multithreaded | CreateFlags.FpuPreserve,
                presentParameters);

            // Create the device using the main window handle, and a placeholder size (1,1).
            // The actual size doesn't matter because whenever we render using this GraphicsDevice,
            // we will make sure the back buffer is large enough for the window we're rendering into.
            // Also, the handle doesn't matter because we call GraphicsDevice.Present(...) with the
            // actual window handle to render into.
            GraphicsDevice = CreateGraphicsDevice(new WindowInteropHelper(window).Handle, 1, 1);
            DeviceCreated?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            DeviceDisposing?.Invoke(this, EventArgs.Empty);
            GraphicsDevice.Dispose();
            D3DDevice?.Dispose();
            D3DContext?.Dispose();
        }

        // Store the current device settings.
        private PresentationParameters _parameters;

        public GraphicsDevice GraphicsDevice { get; private set; }

        public GraphicsDevice CreateGraphicsDevice(IntPtr windowHandle, int width, int height)
        {
            _parameters = new PresentationParameters
            {
                BackBufferWidth = Math.Max(width, 1),
                BackBufferHeight = Math.Max(height, 1),
                BackBufferFormat = SurfaceFormat.Color,
                DepthStencilFormat = DepthFormat.Depth24,
                DeviceWindowHandle = windowHandle,
                PresentationInterval = Microsoft.Xna.Framework.Graphics.PresentInterval.Immediate,
                IsFullScreen = false
            };

            return new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.HiDef, _parameters);
        }

        /// <summary>
        /// Resets the graphics device to whichever is bigger out of the specified
        /// resolution or its current size. This behavior means the device will
        /// demand-grow to the largest of all its GraphicsDeviceControl clients.
        /// </summary>
        public void ResetDevice(int width, int height)
        {
            var newWidth = Math.Max(_parameters.BackBufferWidth, width);
            var newHeight = Math.Max(_parameters.BackBufferHeight, height);

            if (newWidth != _parameters.BackBufferWidth || newHeight != _parameters.BackBufferHeight)
            {
                DeviceResetting?.Invoke(this, EventArgs.Empty);

                _parameters.BackBufferWidth = newWidth;
                _parameters.BackBufferHeight = newHeight;

                // TODO
                //GraphicsDevice.Reset(_parameters);

                DeviceReset?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}