using System.Windows;

namespace QuanLyThuVien
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// </summary>
    public partial class ResetPassword : Window
    {
        public ResetPassword()
        {
            InitializeComponent();
            QuanLyThuVien.ViewModel.ResetPasswordViewModel viewModel = new ResetPasswordViewModel();
            this.DataContext = viewModel;
            viewModel.CloseAction = new Action(this.Close);
        }
    }
}
