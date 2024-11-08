using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LibraSys.View;
using System.Windows;

namespace LibraSys.ViewModel
{
    partial class AddCategoryVM : ObservableObject
    {
        private readonly ProjectPrn211Context db = new ProjectPrn211Context();
        public Action CloseAction { get; internal set; }
        [ObservableProperty]
        private string categoryName;

        [RelayCommand]
        private void SaveCategory()
        {
            if (categoryName != null)
            {
                CategoryBook c = new CategoryBook();
                c.CategoryName = CategoryName;
                db.CategoryBooks.Add(c);
                db.SaveChanges();
                MessageBox.Show("Them thanh cong");
                Admin admin = new Admin();
                admin.Show();
                CloseAction?.Invoke();
            }
        }
        [RelayCommand]
        private void Cancel()
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            CloseAction?.Invoke();
        }
    }
}
