using LibraSys.viewModel;
using System.Windows;

namespace LibraSys
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            var viewModel = new RegisterViewModel();
            DataContext = viewModel;
            viewModel.CloseAction = new Action(this.Close);
        }
    }
}
