using LibraSys.ViewModel;
using System.Windows;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for AddBook.xaml
    /// </summary>
    public partial class AddBook : Window
    {
        public AddBook()
        {
            InitializeComponent();
            var viewModel = new AddBookVM();
            this.DataContext = viewModel;
            viewModel.CloseAction = this.Close;
        }



        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
