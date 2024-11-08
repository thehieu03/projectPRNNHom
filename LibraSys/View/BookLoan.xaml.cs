using BussinessObject.Models;
using System.Windows;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for BookLoan.xaml
    /// </summary>
    public partial class BookLoan : Window
    {
        private ProjectPrn211Context db = new ProjectPrn211Context();
        private int id_user;
        private int? id_book;
        public BookLoan(int userLogin, int? bookID)
        {
            InitializeComponent();
            id_user = userLogin;
            id_book = bookID;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DateTime? ngaymuon = dpNgayMuon.SelectedDate;
            DateTime? ngayTra = dpNgayTra.SelectedDate;
            if (ngaymuon == null)
            {
                MessageBox.Show("Nhập ngày mượn!");
                return;
            }
            if (ngayTra == null)
            {
                MessageBox.Show("Nhập ngày trả!");
                return;
            }
            if (ngayTra < ngaymuon)
            {
                MessageBox.Show("Thoi gian khong hop le!");
                return;
            }
            BookBorrowingRegistrationForm form = new BookBorrowingRegistrationForm();
            form.Id = id_user;
            form.BookId = id_book;
            //form.LoanBorowing = ngaymuon;
        }
    }
}
