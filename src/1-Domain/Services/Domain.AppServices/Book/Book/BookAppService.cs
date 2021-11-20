using Domain.Core.Book.Book.AppServices;
using Domain.Core.Book.Book.DomainServices;
using Domain.Core.Book.Book.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.AppServices.Book.Book
{
    public class BookAppService : IBookAppService
    {
        private readonly IBookService _bookService;
        public BookAppService(IBookService bookService)
        {
            _bookService = bookService;
        }
        public async Task<BookInfo> GetBookInfo(int bookId, CancellationToken cancellationToken)
        {
            return await _bookService.GetBookInfo(bookId, cancellationToken);
        }
    }
}
