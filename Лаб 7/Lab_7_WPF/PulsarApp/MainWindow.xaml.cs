using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace PulsarApp
{
    public partial class MainWindow : Window
    {
        private RadialGradientBrush _gradientBrush;
        private DoubleAnimation _animation;

        public MainWindow()
        {
            InitializeComponent();
            _gradientBrush = new RadialGradientBrush();
            _gradientBrush.GradientStops.Add(new GradientStop(Colors.Red, 0.0));
            _gradientBrush.GradientStops.Add(new GradientStop(Colors.Orange, 0.5));
            _gradientBrush.GradientStops.Add(new GradientStop(Colors.Yellow, 1.0));

            MyEllipse.Fill = _gradientBrush;

            _animation = new DoubleAnimation();
            _animation.From = 0.0;
            _animation.To = 1.0;
            _animation.Duration = new Duration(TimeSpan.FromSeconds(1));
            _animation.AutoReverse = true;
            _animation.RepeatBehavior = RepeatBehavior.Forever;

            _gradientBrush.GradientStops[1].BeginAnimation(GradientStop.OffsetProperty, _animation);
        }
    }
}