using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Windows;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for ListBookingsWindow.xaml
    /// </summary>
    public partial class ListBookingsWindow : Window
    {
        ListBookingsViewModel vm;
        private User activeUser;

        public ListBookingsWindow(User activeUser)
        {
            InitializeComponent();
            vm = new ListBookingsViewModel(activeUser);
            DataContext = vm;

            this.activeUser = activeUser;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow(Choice.listBookings);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }

        private void btn_Booking_Click(object sender, RoutedEventArgs e)
        {
            ViewBookingWindow viewBookingsWindow = new ViewBookingWindow(activeUser);
            this.Visibility = Visibility.Hidden;
            viewBookingsWindow.Show();
        }

        private void btn_NewBooking_Click(object sender, RoutedEventArgs e)
        {
            CreateBookingWindow createBookingWindow = new CreateBookingWindow(activeUser);
            this.Visibility = Visibility.Hidden;
            createBookingWindow.Show();
        }
    }
}
