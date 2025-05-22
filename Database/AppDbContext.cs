using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;
using UrlShortenerProject.Entities;
using UrlShortener.Database;

namespace UrlShortener.Database
{
    public class AppDbContext : DbContext
    {
        internal object urlShortening;

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<urlShortening> UrlShortenings { get; set; }
        public DbSet<redirectLog> RedirectLogs { get; set; }
    }
}
