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
        private Choice choice;
        public CreateBookingWindow(User activeUser, Choice choice)
        {
            InitializeComponent();

            vm = new CreateBookingViewModel(activeUser);
            DataContext = vm;

            this.activeUser = activeUser;
            this.choice = choice;

        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            AccessWindow accessWindow = new AccessWindow(choice);
            this.Visibility = Visibility.Hidden;
            accessWindow.Show();
        }
    }
}
