using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Book
{




    public class Rootobject
    {
        public Relatedbooks[] relatedBooks { get; set; }
    }

    public class Relatedbooks
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
        public Book[] books { get; set; }
        public int layout { get; set; }
        public bool showPrice { get; set; }
    }

    public class Book
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
        public File[] files { get; set; }
        public object[] labels { get; set; }
        public Category[] categories { get; set; }
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
}