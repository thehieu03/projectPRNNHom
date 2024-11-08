using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraSys.View;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Windows;

namespace LibraSys.ViewModel
{
    partial class AdminBookVM : ObservableObject
    {
        private readonly ProjectPrn211Context db = new ProjectPrn211Context();
        public Action CloseAction { get; set; }
        [ObservableProperty]
        private ObservableCollection<Book> bookList;
        [ObservableProperty]
        private string? searchBook;
        [RelayCommand]
        private void Add()
        {
            AddBook a = new AddBook();
            a.Show();
            CloseAction?.Invoke();
        }
        public void loadData()
        {
            BookList = new ObservableCollection<Book>(db.Books
              .Include(b => b.Author)
              .Include(b => b.Category)
              .ToList());
        }
        public AdminBookVM()
        {
            loadData();
        }
        [RelayCommand]
        public void Delete(int bookID)
        {
            Book book = db.Books.FirstOrDefault(c => c.BookId == bookID);
            if (book != null)
            {
                db.Books.Remove(book);
                db.SaveChanges();
                MessageBox.Show("Xóa thành công");
                loadData();
            }
        }
        [RelayCommand]
        public void Update(int bookID)
        {
            Book book = db.Books.FirstOrDefault(c => c.BookId == bookID);
            if (book != null)
            {
                UpdateBookVM updateBook = new UpdateBookVM(book);
                UpdateBook u = new UpdateBook();
                u.Show();
                CloseAction?.Invoke();
            }
        }
        [RelayCommand]
        public void Search()
        {
            if (SearchBook == null)
            {
                loadData();
                return;
            }
            BookList = new ObservableCollection<Book>(db.Books.Where(c => c.BookName.ToLower().Contains(SearchBook.ToLower()))
              .Include(b => b.Author)
              .Include(b => b.Category)
              .ToList());
        }
    }
}
