namespace Domain.Core.Book.Book.Entities
{
    public class File
    {
        public int Id { get; set; }
        public int Size { get; set; }
        public int Type { get; set; }
        public int BookId { get; set; }
        public int SequenceNo { get; set; }
    }
}
