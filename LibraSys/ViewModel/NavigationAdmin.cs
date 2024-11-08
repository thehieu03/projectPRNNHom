using LibraSys.Utilities;
using LibraSys.View;
using System.Windows.Input;

namespace LibraSys.ViewModel
{
    class NavigationAdmin : ViewModelBase
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }

        public ICommand AccountCommand { get; set; }
        public ICommand BookCommand { get; set; }
        public ICommand AthorCommand { get; set; }
        public ICommand OrdersCommand { get; set; }


        private void Home(object obj) => CurrentView = new AccountControl();
        private void BookView(object obj) => CurrentView = new AdminBook();
        private void AthorView(object obj) => CurrentView = new AthorControl();
        private void OrderView(object obj) => CurrentView = new OrderControl();

        public NavigationAdmin()
        {
            AccountCommand = new RelayCommand(Home);
            BookCommand = new RelayCommand(BookView);
            AthorCommand = new RelayCommand(AthorView);
            OrdersCommand = new RelayCommand(OrderView);
            CurrentView = new AccountControl();
        }
    }
}
