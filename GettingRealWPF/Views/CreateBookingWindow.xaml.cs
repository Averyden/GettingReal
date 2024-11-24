using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Windows
{
    /// <summary>
    /// Interaction logic for CreateBookingWindow.xaml
    /// </summary>
    public partial class CreateBookingWindow : Window
    {
        CreateBookingViewModel vm = new CreateBookingViewModel();
        public CreateBookingWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
