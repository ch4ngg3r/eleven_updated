using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace eleven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            textt.Clear();
        }

        // Удалите  labell_TextChanged  и  textt_TextChanged

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            textt.Clear();
        }

        private void textt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textt.Text.Length < 5)
            {
                labell.Foreground = Brushes.Red;
            }
            else
            {
                labell.Foreground = Brushes.Purple;
            } 
        }
    }

    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _userInput;
        public string UserInput
        {
            get { return _userInput; }
            set
            {
                _userInput = value;
                OnPropertyChanged(nameof(UserInput));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
