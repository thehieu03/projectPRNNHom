using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraSys.View;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Forms;

namespace LibraSys.ViewModel
{
    public partial class AddBookVM : ObservableObject
    {
        private readonly ProjectPrn211Context db;
        public Action CloseAction { get; set; }
        [ObservableProperty]
        private string description;
        [ObservableProperty]
        private string bookName;
        [ObservableProperty]
        private int authorID;
        [ObservableProperty]
        private int categoryID;
        [ObservableProperty]
        private int quantity;
        [ObservableProperty]
        private string link;
        [ObservableProperty]
        private ObservableCollection<Author> authorList;
        [ObservableProperty]
        private ObservableCollection<CategoryBook> categoryList;
        public AddBookVM()
        {
            db = new ProjectPrn211Context();
            loadData();
        }
        [RelayCommand]
        private void AddNewAuthor()
        {
            AddAuthor addAuthorDialog = new AddAuthor();
            addAuthorDialog.ShowDialog();
            CloseAction?.Invoke();
        }

        private void loadData()
        {
            AuthorList = new ObservableCollection<Author>(db.Authors.ToList());
            CategoryList = new ObservableCollection<CategoryBook>(db.CategoryBooks.ToList());
        }
        [RelayCommand]
        private void AddCategory()
        {
            AddCategory a = new AddCategory();
            this.CloseAction();
            a.ShowDialog();
        }
        [RelayCommand]
        private void AddBook()
        {
            if (Description == null)
            {
                System.Windows.MessageBox.Show("Enter the Description");
                return;
            }
            if (BookName == null)
            {
                System.Windows.MessageBox.Show("Enter the Book Name");
                return;
            }
            if (AuthorID == null)
            {
                System.Windows.MessageBox.Show("Enter the Author");
                return;
            }
            if (CategoryID == null)
            {
                System.Windows.MessageBox.Show("Enter the CategoryID");
                return;
            }
            if (authorIMG == null)
            {
                System.Windows.MessageBox.Show("Enter the Image");
                return;
            }
            Book book = new Book();
            book.BookName = BookName;
            book.BookDescription = Description;
            book.AuthorId = AuthorID;
            book.CategoryId = CategoryID;
            book.Quantity = Quantity;
            book.BookImg = authorIMG;
            book.Count = 0;
            db.Books.Add(book);
            db.SaveChanges();
            MessageBox.Show("Thêm thành công");
            Admin a = new Admin();
            a.Show();
            CloseAction?.Invoke();
        }
        [RelayCommand]
        private void Close()
        {
            Admin a = new Admin();
            CloseAction?.Invoke();
            a.Show();
        }
        private byte[]? authorIMG;
        [RelayCommand]
        private void Browse()
        {
            var dialog = new OpenFileDialog
            {
                CheckFileExists = true,
                Multiselect = false,
                Filter = "Images (*.jpg,*.png)|*.jpg;*.png|All Files(*.*)|*.*"
            };
            if (dialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            Link = "Chọn thành công";
            authorIMG = File.ReadAllBytes(dialog.FileName);
        }

    }
}
