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
        ViewBookingViewModel vm = new ViewBookingViewModel();
        private User activeUser;
        public ViewBookingWindow(User activeUser)
        {
            InitializeComponent();
            DataContext = vm;

            this.activeUser = activeUser;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            ListBookingsWindow listBookingsWindow = new ListBookingsWindow(activeUser);
            this.Visibility = Visibility.Hidden;
            listBookingsWindow.Show();
        }

    }
}
