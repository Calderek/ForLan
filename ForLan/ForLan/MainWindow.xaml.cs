using System.Windows;
using ForLan.ViewModel;

namespace ForLan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes a new instance of the MainWindow class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Closing += (s, e) => ViewModelLocator.Cleanup();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new View.WordInputWindow();
            w.Show();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window w = new View.LearningView();
            w.Show();
        }
    }
}