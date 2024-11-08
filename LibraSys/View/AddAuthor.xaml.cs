using LibraSys.ViewModel;
using System.Windows;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for AddAuthor.xaml
    /// </summary>
    public partial class AddAuthor : Window
    {
        public AddAuthor()
        {
            InitializeComponent();
            var viewModel = new AddAuthorVM();
            this.DataContext = viewModel;
            viewModel.CloseAction = this.Close;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
