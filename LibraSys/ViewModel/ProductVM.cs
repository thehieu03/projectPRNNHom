using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraSys.View;
using Microsoft.EntityFrameworkCore;
using Responsitory.Contracts;
using Responsitory.Implementations;
using System.Collections.ObjectModel;
using System.Windows;

namespace LibraSys.ViewModel
{
    partial class ProductVM : ObservableObject
    {
        private List<Book> allBooks;
        private int currentPage = 0;
        private int itemsPerPage = 6;
        private ProjectPrn211Context db = new ProjectPrn211Context();
        private readonly IBook _ibook = new BookResponsitory();
        private ObservableCollection<Book> _book;
        [ObservableProperty]
        private User userLogin;

        public ObservableCollection<Book> Books
        {
            get { return _book; }
            set
            {
                _book = value;
                OnPropertyChanged();
            }
        }

        public ProductVM(User userLogin)
        {
            UserLogin = userLogin;
            Books = new ObservableCollection<Book>();
            LoadData();
        }

        public async Task LoadData()
        {
            allBooks = await db.Books
        .Include(b => b.Author)
        .Include(b => b.Category)
        .ToListAsync();
            DisplayCurrentPage();
        }
        private void DisplayCurrentPage()
        {
            if (allBooks == null || !allBooks.Any())
                return;

            var pagedBooks = allBooks
                .Skip(currentPage * itemsPerPage)
                .Take(itemsPerPage)
                .ToList();

            Books.Clear();
            foreach (var book in pagedBooks)
            {
                Books.Add(book);
            }
        }
        [RelayCommand]
        private void Back()
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentPage();
            }
        }
        [RelayCommand]
        private void Next()
        {
            if (allBooks == null || !allBooks.Any())
                return;

            int totalPages = (int)Math.Ceiling((double)allBooks.Count / itemsPerPage);

            if (currentPage + 1 < totalPages)
            {
                currentPage++;
                DisplayCurrentPage();
            }

        }
        [RelayCommand]
        public void RegisterBorrow(int? bookID)
        {
            BookBorrowingRegistrationForm book = new BookBorrowingRegistrationForm();
            book.Id = UserLogin.Id;
            var checkOrder = db.BookBorrowingRegistrationForms.FirstOrDefault(x => x.Id == UserLogin.Id && x.BookId == bookID);
            if (checkOrder != null)
            {
                MessageBox.Show("Bạn đã mượn quyển sách này rồi!");
                return;
            }
            var checkBook = db.Books.FirstOrDefault(x => x.BookId == bookID);
            if (checkBook.Quantity < 0)
            {
                MessageBox.Show("Hết sách");
            }
            book.BookId = bookID;
            BookLoan bookLoan = new BookLoan(UserLogin.Id, bookID);
            bookLoan.ShowDialog();
        }
    }
}
