using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Core.Book.Book.Entities
{

    public class RelatedBook
    {
        public int Type { get; set; }
        public string Title { get; set; }
        public int BackgroundStyle { get; set; }
        public Bookdata BookData { get; set; }
        public Destination Destination { get; set; }
        public BackgroundConfig BackgroundConfig { get; set; }
    }

    public class Bookdata
    {
        public Book[] Books { get; set; }
        public int Layout { get; set; }
        public bool ShowPrice { get; set; }
    }

    public class BackgroundConfig
    {
        public double Style { get; set; }
    }

    public class Destination
    {
        public int Type { get; set; }
        public string PageTitle { get; set; }
        public int Order { get; set; }
        public Filters Filters { get; set; }
        public int NavigationPage { get; set; }
        public int OperationType { get; set; }
        public int BookId { get; set; }
    }

    public class Filters
    {
        public FilterList[] List { get; set; }
    }

    public class FilterList
    {
        public int Value { get; set; }
        public int Count { get; set; }
    }


}
