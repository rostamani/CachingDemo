namespace Domain.Core.Book.Book.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public bool VerifiedAccount { get; set; }
        public string Nickname { get; set; }
        public string ProfileImageUri { get; set; }
        public int BookId { get; set; }
        public string BookCoverUri { get; set; }
        public string BookType { get; set; }
        public string BookName { get; set; }
        public string CreationDate { get; set; }
        public int Rate { get; set; }
        public int RepliesCount { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public string Text { get; set; }
        public bool IsLiked { get; set; }
        public bool IsDisliked { get; set; }
        public RateDetails[] RateDetails { get; set; }
        public int Recommendation { get; set; }
    }
}
