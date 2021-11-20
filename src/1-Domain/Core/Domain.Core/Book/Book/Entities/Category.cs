namespace Domain.Core.Book.Book.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int Parent { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Icon { get; set; }
    }
}
