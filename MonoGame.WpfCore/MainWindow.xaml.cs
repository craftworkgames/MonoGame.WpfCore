using DevComponents.WpfRibbon;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MonoGame.WpfCore
{
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();


     //     UpdateLayout();
        }

        private void mgPanel2_SizeChanged(object sender, SizeChangedEventArgs e)
        {
          
            
        }

        private void mgPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateLayout();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {

            InvalidateMeasure();
            InvalidateArrange();
            UpdateLayout();
        }
    }
}
