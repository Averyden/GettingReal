using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for CreateBookingWindow.xaml
    /// </summary>
    public partial class CreateBookingWindow : Window
    {
        BookingRepository bookingRepo;
        CreateBookingViewModel vm;
        public CreateBookingWindow()
        {
            InitializeComponent();

            bookingRepo = new BookingRepository();
            vm = new CreateBookingViewModel(bookingRepo);
            DataContext = vm;


        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow(AccessViewModel.Choice);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }
    }
}
