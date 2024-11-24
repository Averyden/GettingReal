using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.windows
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        LoginViewModel vm = new LoginViewModel();
        public LoginWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
