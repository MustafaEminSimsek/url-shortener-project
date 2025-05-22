namespace UrlShortenerProject.Entities
{
    public class urlShortening
    {
        public int Id { get; set; }
        public string OriginalUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<redirectLog> AccessLogs { get; set; }
    }   
}
