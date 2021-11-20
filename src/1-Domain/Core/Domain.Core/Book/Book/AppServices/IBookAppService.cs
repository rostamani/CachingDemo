using Domain.Core.Book.Book.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Core.Book.Book.AppServices
{
    public interface IBookAppService
    {
        Task<BookInfo> GetBookInfo(int bookId, CancellationToken cancellationToken);
    }
}
