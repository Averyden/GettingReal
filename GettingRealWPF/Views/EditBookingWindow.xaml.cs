using GettingRealWPF.ViewModels;
using System.Windows;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for EditBookingWindow.xaml
    /// </summary>
    public partial class EditBookingWindow : Window
    {
        EditBookingViewModel vm = new EditBookingViewModel();
        public EditBookingWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }

        
    }
}
