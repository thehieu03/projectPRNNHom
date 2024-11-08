using LibraSys.ViewModel;
using System.Windows;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {
        public AddCategory()
        {
            InitializeComponent();
            var viewModel = new AddCategoryVM();
            this.DataContext = viewModel;
            viewModel.CloseAction = this.Close;
        }
    }
}
