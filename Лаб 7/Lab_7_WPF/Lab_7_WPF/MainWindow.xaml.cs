using System.Windows;
using System.Windows.Input;

namespace Lab_7_WPF
{
    public partial class MainWindow : Window
    {
        private Random _random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            double windowWidth = this.Width;
            double windowHeight = this.Height;

            double buttonWidth = MyButton.ActualWidth;
            double buttonHeight = MyButton.ActualHeight;

            double left = _random.NextDouble() * (windowWidth - buttonWidth);
            double top = _random.NextDouble() * (windowHeight - buttonHeight);

            MyButton.Margin = new Thickness(left, top, 0, 0);
        }
    }
}