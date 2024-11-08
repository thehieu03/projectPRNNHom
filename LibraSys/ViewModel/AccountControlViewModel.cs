using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Responsitory.dal;
using Responsitory.Implementations;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace LibraSys.ViewModel
{
    partial class AccountControlViewModel : ObservableObject
    {
        private readonly ProjectPrn211Context db = new ProjectPrn211Context();
        private IUser iuser = new UserResponsitory();
        private ObservableCollection<User> _users;
        [ObservableProperty]
        private string searchUser;
        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged(nameof(Users));
            }
        }
        [RelayCommand]
        private void Search()
        {
            if (!string.IsNullOrEmpty(searchUser))
            {
                var filteredUsers = db.Users
                              .Where(c => c.UserName.ToLower().Contains(searchUser.ToLower()))
                              .ToList();

                Users = new ObservableCollection<User>(filteredUsers);
            }
        }
        public ICommand DeleteCommand { get; set; }
        public AccountControlViewModel()
        {
            Users = new ObservableCollection<User>();
            LoadData();
        }
        public async void LoadData()
        {
            var allUser = await iuser.GetAllUsersAsync();
            DeleteCommand = new RelayCommand<int>(DeleteUser);
            Users = new ObservableCollection<User>(allUser);
        }

        private async void DeleteUser(int obj)
        {
            if (obj != null)
            {
                await iuser.DeleteUserAsync(obj);
            }
            LoadData();
        }
    }
}
