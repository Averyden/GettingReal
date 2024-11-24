using System.Windows;
using GettingRealWPF.ViewModels;

namespace GettingRealWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel vm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}