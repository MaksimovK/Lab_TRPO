using System.Windows;
using System.Windows.Controls;

namespace Lab_6_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBox1.Clear();
            txtBox2.Clear();
            btnClose.IsEnabled = false;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void cmbFonts_SelectionChanged(object sender, RoutedEventArgs e)
        {
            UpdateTextBoxStyles();
        }

        private void UpdateTextBoxStyles()
        {
            txtBox1.Style = FindResource("TextBoxStyle") as Style;
            txtBox2.Style = FindResource("TextBoxStyle") as Style;
        }

        private void UpdateCloseButtonState()
        {
            btnClose.IsEnabled = string.IsNullOrWhiteSpace(txtBox1.Text) && string.IsNullOrWhiteSpace(txtBox2.Text);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCloseButtonState();
        }
    }
}