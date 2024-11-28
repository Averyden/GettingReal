using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models.Enumerations;
using GettingRealWPF.Models.Repositories;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for AccessWindow.xaml
    /// </summary>
    public partial class AccessWindow : Window
    {
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
            vm.SaveCredentials(tbName.Text, tbPhone.Text);
            vm.testMethodForSavingABooking();
            this.Visibility = Visibility.Hidden;

            
       
            if (choice == Choice.createBooking)
            {
                CreateBookingWindow createBookingWindow = new CreateBookingWindow();
                createBookingWindow.Show();
            }
            else if (choice == Choice.listBookings)
            {
                ListBookingsWindow listBookingsWindow = new ListBookingsWindow();
                listBookingsWindow.Show();
            }
        }
    }
}