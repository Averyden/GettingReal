using System.Windows;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for ViewBookingWindow.xaml
    /// </summary>
    public partial class ViewBookingWindow : Window
    {
        ViewBookingViewModel vm;

        private User activeUser;
        private Booking booking;
        public ViewBookingWindow(User activeUser, Booking booking)
        {
            InitializeComponent();
            vm = new ViewBookingViewModel(booking);
            DataContext = vm;

            this.activeUser = activeUser;
            this.booking = booking;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ListBookingsWindow listBookingsWindow = new ListBookingsWindow(activeUser);
            this.Visibility = Visibility.Hidden;
            listBookingsWindow.Show();
        }

    }
}
