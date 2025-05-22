using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using UrlShortener.Database;
using UrlShortenerProject.Entities;

namespace UrlShortener.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShortenController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ShortenController(AppDbContext context)
        {
            _context = context;
        }


        [HttpPost("random")]
        public async Task<IActionResult> ShortenRandom([FromBody] UrlRequest request)
        {
            var code = Guid.NewGuid().ToString("N")[..6];
            var entity = new urlShortening
            {
                OriginalUrl = request.Url,
                ShortUrl = code
            }; 


            _context.urlShortening = entity;
            await _context.SaveChangesAsync();

            return Ok(new { shortUrl = $"/direct/{code}" });
        }

        public class UrlRequest
        {
            public string Url { get; set; }
        }
    }
}
