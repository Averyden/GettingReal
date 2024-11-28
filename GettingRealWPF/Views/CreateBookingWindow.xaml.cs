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


            Debug.WriteLine(AccessViewModel.Name);
            Debug.WriteLine(AccessViewModel.PhoneNumber);
        }
    }
}
