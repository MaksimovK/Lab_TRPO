using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_10_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Toggle_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            RotateIndicator(toggleButton);
        }

        private void Toggle_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            ScaleToggleButton(toggleButton, 120);
        }

        private void Toggle_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            ToggleButton toggleButton = (ToggleButton)sender;
            ScaleToggleButton(toggleButton, 100);
        }

        private void ScaleToggleButton(ToggleButton toggleButton, double size)
        {
            DoubleAnimation widthAnimation = new DoubleAnimation(size, TimeSpan.FromSeconds(0.5));
            DoubleAnimation heightAnimation = new DoubleAnimation(size, TimeSpan.FromSeconds(0.5));
            toggleButton.BeginAnimation(Button.WidthProperty, widthAnimation);
            toggleButton.BeginAnimation(Button.HeightProperty, heightAnimation);
        }

        private void RotateIndicator(ToggleButton toggleButton)
        {
            RotateTransform rotateTransform = ((toggleButton.Template.FindName("indicator", toggleButton) as Path)?.RenderTransform as RotateTransform);
            if (rotateTransform != null)
            {
                DoubleAnimation animation = new DoubleAnimation(rotateTransform.Angle + 20, TimeSpan.FromSeconds(0.5));
                rotateTransform.BeginAnimation(RotateTransform.AngleProperty, animation);
            }
        }
    }
}