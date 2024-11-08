using BussinessObject.Models;
using DataAccessLayer;
using Responsitory.Contracts;

namespace Responsitory.Implementations
{
    public class BookResponsitory : IBook
    {
        public async Task<List<Book>> getAllBook()
        {
            return await BookDAO.Instance.getAllBook();
        }
    }
}
