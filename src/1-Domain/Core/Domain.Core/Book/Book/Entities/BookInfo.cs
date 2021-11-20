using System;
namespace Domain.Core.Book.Book.Entities
{
    public class BookInfo
    {
        public Book Book { get; set; }
        public Comment[] Comments { get; set; }
        public int CommentsCount { get; set; }
        public RelatedBook[] RelatedBooks { get; set; }
        public string ShareText { get; set; }
        public Quote[] Quotes { get; set; }
        public int QuotesCount { get; set; }
        public bool HideOffCoupon { get; set; }
    }

   
    
    
    
    
    
    

    



}







