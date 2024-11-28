using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for ListBookingsWindow.xaml
    /// </summary>
    public partial class ListBookingsWindow : Window
    {
        ListBookingsViewModel vm = new ListBookingsViewModel();
        public ListBookingsWindow()
        {
            InitializeComponent();
            DataContext = vm;

            Debug.WriteLine(AccessViewModel.Name);
            Debug.WriteLine(AccessViewModel.PhoneNumber);
        }

        private void StackPanel_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
