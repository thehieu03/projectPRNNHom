using MaterialDesignThemes.Wpf;
using QuanLyThuVien.viewModel;
using Responsitory.dal;
using Responsitory.Implementations;
using System.Windows;
using System.Windows.Input;

namespace WPF
{
    /// <summary>
    /// Interaction logic for LoginNew.xaml
    /// </summary>
    public partial class LoginNew : Window
    {
        private readonly IUser _iUser;
        public LoginNew()
        {
            InitializeComponent();
            _iUser = new UserResponsitory();
        }
        public bool IsDarkTheme { get; set; }
        private void toggleTheme(object sender, RoutedEventArgs e)
        {
            var paletteHelper = new PaletteHelper();
            var theme = paletteHelper.GetTheme();
            if (IsDarkTheme = theme.GetBaseTheme() == BaseTheme.Dark)
            {
                IsDarkTheme = false;
                theme.SetBaseTheme(BaseTheme.Light);
            }
            else
            {
                IsDarkTheme = true;
                theme.SetBaseTheme(BaseTheme.Dark);
            }
            paletteHelper.SetTheme(theme);
        }

        private void exitApp(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            DragMove();
        }

        private async void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Password;
            if (userName.Length == 0)
            {
                MessageBox.Show("Enter the User Name");
                return;
            }
            if (passWord.Length == 0)
            {
                MessageBox.Show("Enter the PassWord");
                return;
            }
            var user = await _iUser.GetUserAsync(userName, passWord);
            if (user == null)
            {
                MessageBox.Show("Login that bai");
                return;
            }
            int roleID = user.RoleId ?? 0;
            switch (roleID)
            {
                case 1:
                    Admin admin = new Admin();
                    AdminViewModel adminViewModel = new AdminViewModel(user);
                    admin.Show();
                    this.Close();
                    break;
                case 2:
                    Customer customer = new Customer();
                    CustomerViewModel customerViewModel = new CustomerViewModel(user);
                    customer.Show();
                    this.Close();
                    break;
            }
        }

        private void forgetPassword_Click(object sender, RoutedEventArgs e)
        {
            ResetPassword r = new ResetPassword();
            r.Show();
            this.Close();
        }

        private void signupBtn_Click(object sender, RoutedEventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Close();
        }
    }
}
