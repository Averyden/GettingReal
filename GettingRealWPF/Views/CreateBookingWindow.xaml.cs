using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;
using GettingRealWPF.Models.Classes;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for CreateBookingWindow.xaml
    /// </summary>
    public partial class CreateBookingWindow : Window
    {

        BookingRepository bookingRepo;
        CreateBookingViewModel vm;

        private User activeUser;
        public CreateBookingWindow(User activeUser)
        {
            InitializeComponent();

            bookingRepo = new BookingRepository();
            vm = new CreateBookingViewModel(bookingRepo);
            DataContext = vm;

            this.activeUser = activeUser;

        }

        /*private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow(AccessViewModel.Choice);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }*/

        private void btnNewPerson_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
