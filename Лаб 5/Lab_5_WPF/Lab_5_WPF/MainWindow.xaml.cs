using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation; 

namespace Lab_5_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Создание градиента
            LinearGradientBrush gradientBrush = new LinearGradientBrush();
            gradientBrush.GradientStops.Add(new GradientStop(Colors.LightBlue, 0));
            gradientBrush.GradientStops.Add(new GradientStop(Colors.White, 1));

            // Применение градиента к двум панелям
            LeftPanel.Background = gradientBrush;
            RightPanel.Background = gradientBrush;

            // Установка стилей для текстовых полей
            Style largeTextBoxStyle = new Style(typeof(TextBox));
            largeTextBoxStyle.Setters.Add(new Setter(TextBox.FontSizeProperty, 18.0));
            Style smallTextBoxStyle = new Style(typeof(TextBox));
            smallTextBoxStyle.Setters.Add(new Setter(TextBox.FontSizeProperty, 12.0));

            // Создание текстовых полей
            TextBox largeTextBox1 = new TextBox();
            largeTextBox1.Style = largeTextBoxStyle;
            TextBox largeTextBox2 = new TextBox();
            largeTextBox2.Style = largeTextBoxStyle;

            TextBox smallTextBox1 = new TextBox();
            smallTextBox1.Style = smallTextBoxStyle;
            TextBox smallTextBox2 = new TextBox();
            smallTextBox2.Style = smallTextBoxStyle;

            // Добавление текстовых полей в панели
            LeftPanel.Children.Add(largeTextBox1);
            LeftPanel.Children.Add(smallTextBox1);
            RightPanel.Children.Add(largeTextBox2);
            RightPanel.Children.Add(smallTextBox2);

            // Создание анимации
            DoubleAnimation animation = new DoubleAnimation();
            animation.From = 0.0;
            animation.To = 1.0;
            animation.Duration = new Duration(TimeSpan.FromSeconds(2));

            // Применение анимации к текстовым полям
            largeTextBox1.BeginAnimation(TextBox.OpacityProperty, animation);
            largeTextBox2.BeginAnimation(TextBox.OpacityProperty, animation);
            smallTextBox1.BeginAnimation(TextBox.OpacityProperty, animation);
            smallTextBox2.BeginAnimation(TextBox.OpacityProperty, animation);
        }
    }
}
