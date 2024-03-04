using System.Windows;
using System.Windows.Media.Imaging;


namespace Lab_11
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Stack1.image.Source = new BitmapImage(new Uri("Images/1.jpg", UriKind.Relative));
            Stack1.textbox.Text = "https://ejin.ru/wp-content/uploads/2017/09/20-416.jpg";
            Stack2.image.Source = new BitmapImage(new Uri("Images/2.jpg", UriKind.Relative));
            Stack2.textbox.Text = "https://sportishka.com/uploads/posts/2022-11/1667569036_10-sportishka-com-p-samie-krasivie-vidi-prirodi-oboi-11.jpg";
            Stack3.image.Source = new BitmapImage(new Uri("Images/3.jpg", UriKind.Relative));
            Stack3.textbox.Text = "https://sportishka.com/uploads/posts/2022-09/1662113988_35-sportishka-com-p-krasivaya-priroda-gori-krasivo-41.jpg";
            Stack4.image.Source = new BitmapImage(new Uri("Images/4.jpeg", UriKind.Relative));
            Stack4.textbox.Text = "https://w.forfun.com/fetch/c3/c381b81581e7923c4a0a869bf895c1c9.jpeg";
            Stack5.image.Source = new BitmapImage(new Uri("Images/5.jpg", UriKind.Relative));
            Stack5.textbox.Text = "https://fikiwiki.com/uploads/posts/2022-02/1644855636_51-fikiwiki-com-p-kartinki-khd-kachestva-54.jpg";
            Stack6.image.Source = new BitmapImage(new Uri("Images/6.jpeg", UriKind.Relative));
            Stack6.textbox.Text = "https://w.forfun.com/fetch/3e/3e4ea4a1826bf50b6fafa67dbdbb668c.jpeg";
            Stack7.image.Source = new BitmapImage(new Uri("Images/7.jpeg", UriKind.Relative));
            Stack7.textbox.Text = "https://w.forfun.com/fetch/61/61b955329b11551431249c8e448c124a.jpeg";
            Stack8.image.Source = new BitmapImage(new Uri("Images/8.jpg", UriKind.Relative));
            Stack8.textbox.Text = "https://mykaleidoscope.ru/x/uploads/posts/2022-10/1666374445_6-mykaleidoscope-ru-p-priroda-ozero-oboi-6.jpg";
            Stack9.image.Source = new BitmapImage(new Uri("Images/9.jpg", UriKind.Relative));
            Stack9.textbox.Text = "https://gas-kvas.com/uploads/posts/2023-02/1675432690_gas-kvas-com-p-fonovii-risunok-rabochego-stola-hd-48.jpg";
        }
    }
}