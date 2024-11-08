using BussinessObject.Models;
using LibraSys.ViewModel;
using System.Windows.Controls;

namespace LibraSys.View
{
    /// <summary>
    /// Interaction logic for Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {
        public Products(User user)
        {
            InitializeComponent();
            var viewModel = new ProductVM(user);
            this.DataContext = viewModel;
        }
    }
}
