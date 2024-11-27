using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void btn_CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow();
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }

        private void btn_ViewEditBooking_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow();
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }
    }
}