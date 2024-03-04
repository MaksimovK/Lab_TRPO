using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;

namespace Lab_3_WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
    }

    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            ChangeColorCommand = new RelayCommand(ChangeColor);
            AboutDeveloperCommand = new RelayCommand(AboutDeveloper);
            ExitCommand = new RelayCommand(Exit);
        }

        public ICommand ChangeColorCommand { get; }
        public ICommand AboutDeveloperCommand { get; }
        public ICommand ExitCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void ChangeColor()
        {
            BackgroundColor = "LightBlue";
            StatusBarText = "Цвет фона изменен";
        }

        private void AboutDeveloper()
        {
            MessageBox.Show("Разработчик: Кирилл");
            StatusBarText = "Информация о разработчике";
        }

        private void Exit()
        {
            Application.Current.MainWindow.Close();
        }

        private string _backgroundColor;
        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged();
            }
        }

        private string _statusBarText;
        public string StatusBarText
        {
            get { return _statusBarText; }
            set
            {
                _statusBarText = value;
                OnPropertyChanged();
            }
        }
    }

    public class RelayCommand : ICommand
    {
        private readonly Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }
    }
}
