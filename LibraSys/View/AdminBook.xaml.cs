using LibraSys.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for AdminBook.xaml
    /// </summary>
    public partial class AdminBook : UserControl
    {
        public AdminBook()
        {
            InitializeComponent();
            var viewModel = new AdminBookVM();
            this.DataContext = viewModel;
            viewModel.CloseAction = () =>
            {
                Window.GetWindow(this)?.Close();
            };
        }
    }
}
