using Domain.Core.Book.Book.AppServices;
using Domain.Core.Book.Book.Data.Repositories;
using Domain.Core.Book.Book.Entities;
using Domain.Core.Providers.Cache.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IMemoryCache _memoryCache;
        private readonly ICache _cache;
        private readonly IBookAppService _bookAppService;
        private readonly DistributedCacheEntryOptions _cacheSettings;
        private readonly MemoryCacheEntryOptions _memoryCacheSettings;

        public BooksController(IMemoryCache memoryCache, ICache cache, IBookAppService bookAppService, DistributedCacheEntryOptions cacheSettings, MemoryCacheEntryOptions memoryCacheSettings)
        {
            _memoryCache = memoryCache;
            _cache = cache;
            _bookAppService = bookAppService;
            _cacheSettings = new DistributedCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(1));
            _memoryCacheSettings = new MemoryCacheEntryOptions().SetAbsoluteExpiration(TimeSpan.FromHours(1)).SetSize(1024);
        }
        [HttpGet("{bookId}")]
        public async Task<IActionResult> Get(int bookId,CancellationToken cancellationToken)
        {
            BookInfo bookInfoResult = null;

            if (_memoryCache.TryGetValue<BookInfo>(bookId,out bookInfoResult))
            {
                return Ok(bookInfoResult);
            }

            bookInfoResult = await _cache.GetAsync<BookInfo>(bookId.ToString(), cancellationToken);
            if (bookInfoResult is not null)
            {
                return Ok(bookInfoResult);
            }

            bookInfoResult = await _bookAppService.GetBookInfo(bookId, cancellationToken);
            if (bookInfoResult is not null)
            {
                
                _memoryCache.Set(bookId, bookInfoResult,_memoryCacheSettings);
                await _cache.SetAsync(bookId.ToString(), bookInfoResult, _cacheSettings, cancellationToken);
                return Ok(bookInfoResult);
            }

            return NoContent();
        }
    }
}
