using System.Xml.Serialization;

namespace UrlShortenerProject.Entities
{
    public class redirectLog
    {
        public int Id { get; set; }
        public DateTime AccessedAt { get; set; } = DateTime.UtcNow;

        public int urlShorteningId { get; set; }
        public urlShortening urlShortening { get; set; }
    }
}
