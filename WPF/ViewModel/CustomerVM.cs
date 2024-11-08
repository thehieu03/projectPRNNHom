using BussinessObject.Models;
using QuanLyThuVien.Utilities;

namespace QuanLyThuVien.ViewModel
{
    class CustomerVM : ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            get { return PageModel.CustomerCount; }
            set { PageModel.CustomerCount = value; OnPropertyChanged(); }
        }

        public PageModel PageModel => _pageModel;

        public CustomerVM()
        {
            _pageModel = new PageModel();
            CustomerID = 100528;
        }
    }
}
