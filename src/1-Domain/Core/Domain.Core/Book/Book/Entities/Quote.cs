using System;

namespace Domain.Core.Book.Book.Entities
{
    public class Quote
    {
        public string Id { get; set; }
        public QuoteData Data { get; set; }
        public int LikeCount { get; set; }
        public int BookId { get; set; }
        public int AccountId { get; set; }
        public int CommentCount { get; set; }
        public string CreationDate { get; set; }
        public DateTime Date { get; set; }
        public bool ShowComment { get; set; }
        public string CoverUri { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string ProfileImageUri { get; set; }
        public string Nickname { get; set; }
    }
}
