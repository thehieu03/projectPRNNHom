using System.Windows;

namespace WPF
{
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            var viewModel = new viewModel.RegisterViewModel();
            DataContext = viewModel;
            viewModel.CloseAction = new Action(this.Close);


        }
    }
}
