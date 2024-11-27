using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF.Views
{
    /// <summary>
    /// Interaction logic for AccessWindow.xaml
    /// </summary>
    public partial class AccessWindow : Window
    {
        LoginViewModel vm = new LoginViewModel();
        public AccessWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
