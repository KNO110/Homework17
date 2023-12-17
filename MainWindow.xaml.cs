//Powered by Ak1ne

using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace YourNamespace
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            KeyGesture keyGestureGreen = new KeyGesture(Key.G, ModifierKeys.Control);
            KeyGesture keyGestureRed = new KeyGesture(Key.R, ModifierKeys.Control);
            KeyGesture keyGestureBlue = new KeyGesture(Key.B, ModifierKeys.Control);

            InputBindings.Add(new KeyBinding(new RelCom(GreenC), keyGestureGreen));
            InputBindings.Add(new KeyBinding(new RelCom(RedC), keyGestureRed));
            InputBindings.Add(new KeyBinding(new RelCom(BlueC), keyGestureBlue));
        }

        private void GreenC()
        {
            myButton.Background = Brushes.Green;
        }

        private void RedC()
        {
            myButton.Background = Brushes.Red;
        }

        private void BlueC()
        {
            myButton.Background = Brushes.Blue;
        }
    }
    public class RelCom : ICommand
    {
        private readonly Action _execute;

        public RelCom(Action execute)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute?.Invoke();
        }

        public event EventHandler CanExecuteChanged;
    }
}


///Powered by Ak1ne
