using System.Windows;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();
        private Choice choice;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        private void btn_CreateBooking_Click(object sender, RoutedEventArgs e)
        {
            choice = Choice.createBooking;
            AccessWindow accessWindow = new AccessWindow(choice);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }

        private void btn_ViewEditBooking_Click(object sender, RoutedEventArgs e)
        {
            choice = Choice.listBookings;
            AccessWindow accessWindow = new AccessWindow(choice);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }
    }
}