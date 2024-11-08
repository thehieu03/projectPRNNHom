using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class BookDAO : SingletonBase<BookDAO>
    {
        public async Task<List<Book>> getAllBook()
        {
            var conext = BookDAO.GetContext();
            return await conext.Books.ToListAsync();
        }
    }
}
