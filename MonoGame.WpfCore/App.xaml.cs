using System.Windows;
using MonoGame.WpfCore.MonoGameControls;

namespace MonoGame.WpfCore
{
    public partial class App : Application
    {
        private readonly MonoGameGraphicsDeviceService _graphicsDeviceService = new MonoGameGraphicsDeviceService();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            ShutdownMode = ShutdownMode.OnMainWindowClose;
            MainWindow = new MainWindow();
            MainWindow.Show();

            _graphicsDeviceService.StartD3D(MainWindow);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            _graphicsDeviceService.Dispose();

            base.OnExit(e);
        }
    }
}
