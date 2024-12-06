using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.Models.Repositories;
using System.Diagnostics;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for AccessWindow.xaml
    /// </summary>
    public partial class AccessWindow : Window
    {

        BookingRepository bookingRepository = new BookingRepository();
        AccessViewModel vm = new AccessViewModel();
        private Choice choice;

        public AccessWindow(Choice choice)
        {
            InitializeComponent();
            DataContext = vm;

            this.choice = choice;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }

        private void btn_Continue_Click(object sender, RoutedEventArgs e)
        {
            User activeUser = vm.FetchCredentials(tbName.Text, tbPhone.Text, choice);
            Debug.WriteLine(activeUser.ToString());

            this.Visibility = Visibility.Hidden;
       
            if (choice == Choice.createBooking)
            {
                CreateBookingWindow createBookingWindow = new CreateBookingWindow(activeUser, choice);
                createBookingWindow.Show();
            }
            else if (choice == Choice.listBookings)
            {
                ListBookingsWindow listBookingsWindow = new ListBookingsWindow(activeUser);
                string bookingsFound = bookingRepository.GetBookingsForUser(activeUser);
                if (bookingsFound == "No bookings available for user.")
                {
                    listBookingsWindow.Show();
                    listBookingsWindow.infoLabel.Opacity = 1;
                    listBookingsWindow.infoLabel.Content = "No bookings available for user.";
                    listBookingsWindow.Viewer.Opacity = 0;
                } else { 
                    listBookingsWindow.Show();
                    listBookingsWindow.infoLabel.Opacity = 0;
                    listBookingsWindow.infoLabel.Content = "WHY AM I STILL VISIBLEEEEE";
                    listBookingsWindow.Viewer.Opacity = 1;
                    // TODO: create a new button element INSIDE the viewers STACKPANEL for every single booking inside the thing.
                }
            }
        }
    }
}