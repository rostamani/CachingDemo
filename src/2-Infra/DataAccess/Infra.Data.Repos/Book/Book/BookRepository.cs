using Domain.Core.Book.Book.Data.Repositories;
using Domain.Core.Book.Book.Entities;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Infra.Data.Repos.Book.Book
{
    public class BookRepository : IBookRepository
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BookRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<BookInfo> GetBookInfo(int bookId, CancellationToken cancellationToken)
        {
            var client = _httpClientFactory.CreateClient();
            BookInfo bookInfo = null;
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://get.taaghche.com/v2/book/{bookId}");
            var response = await client.SendAsync(request,cancellationToken);
            if (response.IsSuccessStatusCode)
            {
                var responsesString = await response.Content.ReadAsStringAsync(cancellationToken);
                bookInfo = JsonConvert.DeserializeObject<BookInfo>(responsesString);
            }

            return bookInfo;
        }
    }
}
