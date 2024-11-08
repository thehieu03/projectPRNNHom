using QuanLyThuVien.viewModel;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            DataContext = new AdminViewModel();
        }
    }
}
