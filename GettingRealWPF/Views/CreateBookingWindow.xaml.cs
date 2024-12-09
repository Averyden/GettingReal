using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for CreateBookingWindow.xaml
    /// </summary>
    public partial class CreateBookingWindow : Window
    {
        CreateBookingViewModel vm;

        private User activeUser;
        public CreateBookingWindow(User activeUser)
        {
            InitializeComponent();

            vm = new CreateBookingViewModel(activeUser);
            DataContext = vm;

            this.activeUser = activeUser;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow(Choice.createBooking);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }
    }
}
