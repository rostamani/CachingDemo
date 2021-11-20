using Domain.Core.Book.Book.Data.Repositories;
using Domain.Core.Book.Book.DomainServices;
using Domain.Core.Book.Book.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.Services.Book.Book
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<BookInfo> GetBookInfo(int bookId, CancellationToken cancellationToken)
        {
            return await _bookRepository.GetBookInfo(bookId, cancellationToken);
        }
    }
}
