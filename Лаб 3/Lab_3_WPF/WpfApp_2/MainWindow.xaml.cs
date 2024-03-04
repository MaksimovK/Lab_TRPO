using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace WpfApp_2
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private bool _isDrawMode = true;
        private bool _isEditMode = false;
        private bool _isDeleteMode = false;
        private Shape _currentShape;
        private Point _startPoint;
        private string _selectedColor;
        private double _selectedSize;

        public event PropertyChangedEventHandler PropertyChanged;

        public bool IsDrawMode
        {
            get { return _isDrawMode; }
            set { _isDrawMode = value; OnPropertyChanged(); }
        }

        public bool IsEditMode
        {
            get { return _isEditMode; }
            set { _isEditMode = value; OnPropertyChanged(); }
        }

        public bool IsDeleteMode
        {
            get { return _isDeleteMode; }
            set { _isDeleteMode = value; OnPropertyChanged(); }
        }

        public string SelectedColor
        {
            get { return _selectedColor; }
            set { _selectedColor = value; OnPropertyChanged(); }
        }

        public double SelectedSize
        {
            get { return _selectedSize; }
            set { _selectedSize = value; OnPropertyChanged(); }
        }

        public List<string> AvailableColors { get; } = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;

            foreach (var prop in typeof(System.Windows.Media.Colors).GetProperties())
            {
                AvailableColors.Add(prop.Name);
            }

            SelectedColor = "Black";
            SelectedSize = 1;
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _startPoint = e.GetPosition(myCanvas);

            if (IsDrawMode)
            {
                if (SelectedColor != null)
                {
                    _currentShape = new Ellipse
                    {
                        Width = 0,
                        Height = 0,
                    };
                    Canvas.SetLeft(_currentShape, _startPoint.X);
                    Canvas.SetTop(_currentShape, _startPoint.Y);
                    myCanvas.Children.Add(_currentShape);
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите цвет");
                }
            }
            else if (IsEditMode || IsDeleteMode)
            {
                _currentShape = null;
                foreach (var child in myCanvas.Children)
                {
                    if (child is Ellipse ellipse)
                    {
                        var mousePos = e.GetPosition(myCanvas);
                        var left = Canvas.GetLeft(ellipse);
                        var top = Canvas.GetTop(ellipse);
                        var right = left + ellipse.Width;
                        var bottom = top + ellipse.Height;

                        if (mousePos.X >= left && mousePos.X <= right && mousePos.Y >= top && mousePos.Y <= bottom)
                        {
                            _currentShape = ellipse;
                            break;
                        }
                    }
                }

                if (_currentShape != null)
                {
                    if (IsEditMode)
                    {
                       
                    }
                    else if (IsDeleteMode)
                    {
                        myCanvas.Children.Remove(_currentShape);
                    }
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed && _currentShape != null)
            {
                if (IsDrawMode)
                {
                    var pos = e.GetPosition(myCanvas);
                    var width = pos.X - _startPoint.X;
                    var height = pos.Y - _startPoint.Y;

                    if (Keyboard.IsKeyDown(Key.LeftShift) || Keyboard.IsKeyDown(Key.LeftCtrl))
                    {
                        var size = System.Math.Max(width, height);
                        _currentShape.Width = size < 0 ? 0 : size;
                        _currentShape.Height = size < 0 ? 0 : size;
                    }
                    else
                    {
                        _currentShape.Width = width < 0 ? 0 : width;
                        _currentShape.Height = height < 0 ? 0 : height;
                    }
                }
                else if (IsEditMode)
                {
                    var pos = e.GetPosition(myCanvas);
                    var offsetX = pos.X - _startPoint.X;
                    var offsetY = pos.Y - _startPoint.Y;

                    Canvas.SetLeft(_currentShape, Canvas.GetLeft(_currentShape) + offsetX);
                    Canvas.SetTop(_currentShape, Canvas.GetTop(_currentShape) + offsetY);

                    _startPoint = pos;
                }
            }
        }

        private void myCanvas_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (IsEditMode)
            {
                _currentShape = null;
            }
        }
    }
}
