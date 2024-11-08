using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraSys.validate;
using Responsitory.dal;
using Responsitory.Implementations;
using System.Net;
using System.Net.Mail;
using System.Windows;

namespace LibraSys.viewModel
{
    public partial class ResetPasswordViewModel : ObservableObject
    {
        private readonly Validate v = new Validate();
        private readonly IUser iuser = new UserResponsitory();
        public Action CloseAction { get; set; }
        [ObservableProperty]
        private string? email;
        [ObservableProperty]
        private string? passwordNew1;
        [ObservableProperty]
        private string? passwordNew2;
        [ObservableProperty]
        private int? otpCode;
        Random r = new Random();
        int? otp;
        [RelayCommand]
        private async void Otp()
        {
            if (v.checkEmail(Email))
            {
                MessageBox.Show("Email khong dung dinh danng");
                return;
            }
            if (!await iuser.CheckEmailExistsAsync(Email))
            {
                MessageBox.Show("Email nay chưa được đăng kí");
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
        public async void Change()
        {
            if (v.checkEmail(Email))
            {
                MessageBox.Show("Email không hợp lệ");
                return;
            }
            if (!await iuser.CheckEmailExistsAsync(Email))
            {
                MessageBox.Show("Email đã được đăng kí");
                return;
            }
            if (v.checkStringIsNull(PasswordNew1))
            {
                MessageBox.Show("Vui lòng nhập password");
                return;
            }
            if (v.checkStringIsNull(PasswordNew2))
            {
                MessageBox.Show("Vui lòng nhập đúng password vừa nhập");
                return;
            }
            if (v.checkStringIsNull(OtpCode.ToString()))
            {
                MessageBox.Show("Vui lòng nhập OTP code đúng định dạng");
                return;
            }
            if (!PasswordNew1.Equals(PasswordNew2))
            {
                MessageBox.Show("2 mật khẩu không trùng với nhau");
                return;
            }
            if (OtpCode != otp)
            {
                MessageBox.Show("Mã OTP sai!");
                return;
            }
            await iuser.UpdatePasswordAsync(Email, PasswordNew1);
            MessageBox.Show("Thay đổi mật khẩu thành công");
            Login login = new Login();
            login.Show();
            CloseAction?.Invoke();
        }
    }
}
