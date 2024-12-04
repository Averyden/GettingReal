using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Windows;
using GettingRealWPF.Models.Classes;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for ListBookingsWindow.xaml
    /// </summary>
    public partial class ListBookingsWindow : Window
    {
        ListBookingsViewModel vm = new ListBookingsViewModel();

        private User activeUser;
        public ListBookingsWindow(User activeUser)
        {
            InitializeComponent();
            DataContext = vm;

            this.activeUser = activeUser;

            Debug.WriteLine(AccessViewModel.Name);
            Debug.WriteLine(AccessViewModel.PhoneNumber);
        }

        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }

        
    }
}
