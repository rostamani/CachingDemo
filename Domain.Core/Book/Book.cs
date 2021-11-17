
using System;

public class APIResult
{
    public Book Book { get; set; }
    public Comment[] Comments { get; set; }
    public int CommentsCount { get; set; }
    public Book[] RelatedBooks { get; set; }
    public string ShareText { get; set; }
    public Quote[] Quotes { get; set; }
    public int QuotesCount { get; set; }
    public bool HideOffCoupon { get; set; }
}

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int SourceBookId { get; set; }
    public int CanonicalId { get; set; }
    public string Description { get; set; }
    public string HtmlDescription { get; set; }
    public int PublisherID { get; set; }
    public string PublisherSlug { get; set; }
    public int Price { get; set; }
    public int NumberOfPages { get; set; }
    public Rate[] Rates { get; set; }
    public RateDetails[] RateDetails { get; set; }
    public string Sticker { get; set; }
    public bool HasTemporaryOff { get; set; }
    public int BeforeOffPrice { get; set; }
    public bool IsRtl { get; set; }
    public bool ShowOverlay { get; set; }
    public int PhysicalPrice { get; set; }
    public int Destination { get; set; }
    public string Type { get; set; }
    public string RefId { get; set; }
    public string CoverUri { get; set; }
    public string ShareUri { get; set; }
    public string ShareText { get; set; }
    public string Publisher { get; set; }
    public Author[] authors { get; set; }
    public File[] Files { get; set; }
    public object[] Labels { get; set; }
    public Category[] Categories { get; set; }
    public bool SubscriptionAvailable { get; set; }
    public DateTime NewsItemCreationDate { get; set; }
    public int State { get; set; }
    public bool Encrypted { get; set; }
    public int CurrencyPrice { get; set; }
    public int CurrencyBeforeOffPrice { get; set; }
}

public class Rate
{
    public int Value { get; set; }
    public int Count { get; set; }
}

public class RateDetails
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Rate { get; set; }
}
public class Quote
{
    public string Id { get; set; }
    public Data Data { get; set; }
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

public class Data
{
    public string Quote { get; set; }
    public int StartAtomId { get; set; }
    public int EndAtomId { get; set; }
    public int ChapterIndex { get; set; }
    public int EndOffset { get; set; }
    public int StartOffset { get; set; }
}





public class Author
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Type { get; set; }
    public string Slug { get; set; }
}

public class File
{
    public int Id { get; set; }
    public int Size { get; set; }
    public int Type { get; set; }
    public int BookId { get; set; }
    public int SequenceNo { get; set; }
}

public class Category
{
    public int Id { get; set; }
    public int Parent { get; set; }
    public string Title { get; set; }
    public string Slug { get; set; }
    public string Icon { get; set; }
}

public class Relatedbook
{
    public int type { get; set; }
    public string title { get; set; }
    public int backgroundStyle { get; set; }
    public Bookdata bookData { get; set; }
    public Destination destination { get; set; }
    public Backgroundconfig backgroundConfig { get; set; }
}

public class Bookdata
{
    public Book1[] books { get; set; }
    public int layout { get; set; }
    public bool showPrice { get; set; }
}





public class Destination
{
    public int type { get; set; }
    public string pageTitle { get; set; }
    public int order { get; set; }
    public Filters filters { get; set; }
    public int navigationPage { get; set; }
    public int operationType { get; set; }
    public int bookId { get; set; }
}

public class Filters
{
    public List[] list { get; set; }
    public string refId { get; set; }
}

public class List
{
    public int type { get; set; }
    public int value { get; set; }
}

public class Backgroundconfig
{
    public int style { get; set; }
}



public class Comment
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public bool VerifiedAccount { get; set; }
    public string Nickname { get; set; }
    public string ProfileImageUri { get; set; }
    public int BookId { get; set; }
    public string BbookCoverUri { get; set; }
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



