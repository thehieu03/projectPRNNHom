using BussinessObject.Models;

namespace Responsitory.Contracts
{
    public interface IBook
    {
        Task<List<Book>> getAllBook();
    }
}
