using BussinessObject.Models;
using LibraSys.ViewModel;
using System.Windows;

namespace LibraSys
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private User currentUser;
        public MainWindow(User user)
        {
            InitializeComponent();
            currentUser = user;
            var viewModel = new NavigationVM(currentUser);
            this.DataContext = viewModel;
        }
        private void CloseApp_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}