using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace WpfApp_2
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string colorName)
            {
                try
                {
                    Color color = (Color)System.Windows.Media.ColorConverter.ConvertFromString(colorName);
                    return new SolidColorBrush(color);
                }
                catch (FormatException)
                {
                    
                }
            }
            return new SolidColorBrush(Colors.Black); 
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
