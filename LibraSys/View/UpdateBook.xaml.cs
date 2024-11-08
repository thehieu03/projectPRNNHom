using LibraSys.ViewModel;
using System.Windows;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for UpdateBook.xaml
    /// </summary>
    public partial class UpdateBook : Window
    {
        public UpdateBook()
        {
            InitializeComponent();
            var viewModel = new UpdateBookVM();
            this.DataContext = viewModel;
            viewModel.CloseAction = this.Close;
        }
    }
}
