using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for ViewBookingWindow.xaml
    /// </summary>
    public partial class ViewBookingWindow : Window
    {
        ViewBookingViewModel vm = new ViewBookingViewModel();
        public ViewBookingWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
