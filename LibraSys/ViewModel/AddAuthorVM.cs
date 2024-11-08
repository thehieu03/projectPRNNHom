using BussinessObject.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LibraSys.ViewModel
{
    partial class AddAuthorVM : ObservableObject
    {
        public Action CloseAction { get; set; }
        private readonly ProjectPrn211Context db = new ProjectPrn211Context();
        [ObservableProperty]
        private string authorName;
        [RelayCommand]
        private void AddAuthor()
        {
            if (this.authorName != null)
            {
                Author author = new Author();
                author.AuthorName = AuthorName;
                db.Authors.Add(author);
                db.SaveChanges();
                System.Windows.MessageBox.Show("Add thang cong");
                CloseAction?.Invoke();
            }
        }
    }
}
