using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace Domain.Core.Book.Book.Entities
{
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
        public double Price { get; set; }
        public int NumberOfPages { get; set; }
        public Rate[] Rates { get; set; }
        public RateDetails[] RateDetails { get; set; }
        public string Sticker { get; set; }
        public bool HasTemporaryOff { get; set; }
        public double BeforeOffPrice { get; set; }
        public bool IsRtl { get; set; }
        public bool ShowOverlay { get; set; }
        public double PhysicalPrice { get; set; }
        public int Destination { get; set; }
        public string Type { get; set; }
        public string RefId { get; set; }
        public string CoverUri { get; set; }
        public string ShareUri { get; set; }
        public string ShareText { get; set; }
        public string Publisher { get; set; }
        public Author[] Authors { get; set; }
        public File[] Files { get; set; }
        public object[] Labels { get; set; }
        public Category[] Categories { get; set; }
        public bool SubscriptionAvailable { get; set; }
        public DateTime NewsItemCreationDate { get; set; }
        public double State { get; set; }
        public bool Encrypted { get; set; }
        public double CurrencyPrice { get; set; }
        public double CurrencyBeforeOffPrice { get; set; }
    }
}
