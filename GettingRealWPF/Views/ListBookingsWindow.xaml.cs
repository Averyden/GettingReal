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
        }
    }
}
