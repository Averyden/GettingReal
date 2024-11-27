using System.Windows;
using GettingRealWPF.ViewModels;
using GettingRealWPF.Models.Enumerations;

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

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            mainWindow.Show();
        }
    }
}
