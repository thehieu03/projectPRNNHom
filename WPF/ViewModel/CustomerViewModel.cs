using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows;

namespace QuanLyThuVien.viewModel
{
    public partial class CustomerViewModel : ObservableObject
    {
        private User user;
        public CustomerViewModel()
        {
            MessageBox.Show("Login thanh cong");
        }
        public CustomerViewModel(User u)
        {
            this.user = u;
            MessageBox.Show(u.UserName);
        }
    }
}
