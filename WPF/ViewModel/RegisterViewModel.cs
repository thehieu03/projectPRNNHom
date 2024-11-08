using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Responsitory.dal;
using Responsitory.Implementations;
using System.Net;
using System.Net.Mail;
using System.Windows;
using WPF;

namespace QuanLyThuVien.viewModel
{
    public partial class RegisterViewModel : ObservableObject
    {
        private readonly validate.Validate v = new validate.Validate();
        private readonly IUser iUser = new UserResponsitory();
        public Action CloseAction { get; set; }
        [ObservableProperty]
        private string? username;
        [ObservableProperty]
        private string? email;
        [ObservableProperty]
        private bool isMale = true;
        [ObservableProperty]
        private bool isFemale;
        [ObservableProperty]
        private string? address;
        [ObservableProperty]
        private string? password;
        [ObservableProperty]
        private int? otpCodeText;
        [RelayCommand]
        private async void Save()
        {
            if (v.checkStringIsNull(Username))
            {
                MessageBox.Show("Enter the username");
                return;
            }
            if (await iUser.CheckUserNameExistsAsync(Username))
            {
                MessageBox.Show("UserName đã được sử dụng");
                return;
            }
            if (v.checkEmail(Email))
            {
                MessageBox.Show("Email khong hợp lệ");
                return;
            }
            if (await iUser.CheckEmailExistsAsync(Email))
            {
                MessageBox.Show("Email đã được sử dụng");
            }
            if (v.checkStringIsNull(Address))
            {
                MessageBox.Show("Enter the Address");
                return;
            }
            if (v.checkStringIsNull(Password))
            {
                MessageBox.Show("Enter the Password");
                return;
            }
            User u = new User
            {
                UserName = Username,
                PassWord = Password,
                Email = Email,
                Gender = IsMale ? true : false,
                RoleId = 2,
                UserAddress = Address,
            };
            if (OtpCodeText == otp)
            {
                await iUser.InsertUserAsync(u);
                MessageBox.Show("Đăng kí thành công");
            }
            else
            {
                MessageBox.Show("Đăng kí thất bại");
            }
        }
        Random r = new Random();
        int? otp;
        [RelayCommand]
        private async void OtpCode()
        {
            if (v.checkEmail(Email))
            {
                MessageBox.Show("Email khong hợp lệ");
                return;
            }
            if (await iUser.CheckEmailExistsAsync(Email))
            {
                MessageBox.Show("Email đã được sử dụng");
                return;
            }
            try
            {
                otp = r.Next(100000, 1000000);
                var fromAddress = new MailAddress("hieunthe171211@gmail.com");
                var toAddress = new MailAddress(Email);
                const string fromPass = "dahvajbutfcretda";
                const string subject = "OTP code:";
                string body = otp.ToString();
                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPass),
                    Timeout = 200000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }
                MessageBox.Show("Otp send email");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [RelayCommand]
        public void Login()
        {
            LoginNew login = new LoginNew();
            login.Show();
            CloseAction?.Invoke();
        }

        public RegisterViewModel()
        {

        }

    }
}
