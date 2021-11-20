using Domain.Core.Book.Book.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Core.Book.Book.Data.Repositories
{
    public interface IBookRepository
    {
        Task<BookInfo> GetBookInfo(int bookId, CancellationToken cancellationToken);
    }
}
