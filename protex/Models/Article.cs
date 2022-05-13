namespace protex.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string? AuthorImg { get; set; }
        public string? PublicationDate { get; set; }
        public string? PreviewImg { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Content { get; set; }
        public string? Tags { get; set; }
        public int Watch { get; set; }
        public int Comments { get; set; }
    }
}
