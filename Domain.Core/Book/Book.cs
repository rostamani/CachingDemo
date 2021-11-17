
using System;

public class APIResult
{
    public Book Book { get; set; }
    public object[] Comments { get; set; }
    public int CommentsCount { get; set; }
    public Book[] RelatedBooks { get; set; }
    public string ShareText { get; set; }
    public object[] Quotes { get; set; }
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
    public object[] Rates { get; set; }
    public object[] RateDetails { get; set; }
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
    public object[] authors { get; set; }
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

public class File
{
    public int id { get; set; }
    public int size { get; set; }
    public int type { get; set; }
    public int bookId { get; set; }
    public int sequenceNo { get; set; }
}

public class Category
{
    public int id { get; set; }
    public int parent { get; set; }
    public string title { get; set; }
    public string slug { get; set; }
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

public class Book1
{
    public int id { get; set; }
    public string title { get; set; }
    public int sourceBookId { get; set; }
    public int canonicalId { get; set; }
    public string description { get; set; }
    public string htmlDescription { get; set; }
    public int PublisherID { get; set; }
    public string publisherSlug { get; set; }
    public int price { get; set; }
    public int numberOfPages { get; set; }
    public int rating { get; set; }
    public Rate[] rates { get; set; }
    public object[] rateDetails { get; set; }
    public string sticker { get; set; }
    public bool hasTemporaryOff { get; set; }
    public int beforeOffPrice { get; set; }
    public bool isRtl { get; set; }
    public bool showOverlay { get; set; }
    public int PhysicalPrice { get; set; }
    public int destination { get; set; }
    public string type { get; set; }
    public string refId { get; set; }
    public string coverUri { get; set; }
    public string shareUri { get; set; }
    public string shareText { get; set; }
    public string publisher { get; set; }
    public object[] authors { get; set; }
    public File1[] files { get; set; }
    public object[] labels { get; set; }
    public Category1[] categories { get; set; }
    public bool subscriptionAvailable { get; set; }
    public DateTime newsItemCreationDate { get; set; }
    public int state { get; set; }
    public bool encrypted { get; set; }
    public int currencyPrice { get; set; }
    public int currencyBeforeOffPrice { get; set; }
}

public class Rate
{
    public int value { get; set; }
    public int count { get; set; }
}

public class File1
{
    public int id { get; set; }
    public int size { get; set; }
    public int type { get; set; }
    public int bookId { get; set; }
    public int sequenceNo { get; set; }
}

public class Category1
{
    public int id { get; set; }
    public int parent { get; set; }
    public string title { get; set; }
    public string slug { get; set; }
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



public class Rootobject
{
    public Comment[] comments { get; set; }
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
    public object[] RateDetails { get; set; }
    public int Recommendation { get; set; }
}
