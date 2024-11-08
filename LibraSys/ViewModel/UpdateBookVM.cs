using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace LibraSys.ViewModel
{
    public partial class UpdateBookVM : ObservableObject
    {
        private ProjectPrn211Context db = new ProjectPrn211Context();
        [ObservableProperty]
        private Book books;
        [ObservableProperty]
        private ObservableCollection<Author> authorList;
        [ObservableProperty]
        private ObservableCollection<CategoryBook> categoryList;
        [ObservableProperty]
        private string? description;
        [ObservableProperty]
        private string bookName;
        [ObservableProperty]
        private int? authorID;
        [ObservableProperty]
        private int? categoryID;
        [ObservableProperty]
        private int? quantity;
        [ObservableProperty]
        private string link;
        public UpdateBookVM()
        {
            loadData();
        }

        public UpdateBookVM(Book book)
        {
            this.Books = book;
            loadData();
        }
        private void loadData()
        {
            Description = Books.BookDescription;
            BookName = Books.BookName;
            AuthorID = Books.AuthorId;
            Quantity = Books.Quantity;
            CategoryID = Books.CategoryId;
            AuthorList = new ObservableCollection<Author>(db.Authors.ToList());
            CategoryList = new ObservableCollection<CategoryBook>(db.CategoryBooks.ToList());
        }

        public Action CloseAction { get; internal set; }
    }
}
