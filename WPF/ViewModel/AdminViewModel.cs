using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace QuanLyThuVien.viewModel
{
    public partial class AdminViewModel : ObservableObject
    {
        private User user;
        public AdminViewModel()
        {
            MessageBox.Show("Login thanh cong");
        }
        public AdminViewModel(User u)
        {
            this.user = u;
            MessageBox.Show(u.UserName);
        }
    }
}
