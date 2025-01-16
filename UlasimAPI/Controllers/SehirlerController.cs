using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UlasimAPI.Data;
using UlasimAPI.Models;

namespace UlasimAPI.Controllers
{
    [Route("api/sehirler")]
    [ApiController]
    public class SehirlerController : ControllerBase
    {
        private readonly MyDbContext _context;

        public SehirlerController(MyDbContext context)
        {
            _context = context;
        }

        // Tüm şehirleri getir
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sehir>>> GetSehirler()
        {
            return await _context.Sehirler.ToListAsync();
        }

        // Şehir id'sine göre ulaşım çözümleri getir
        [HttpGet("{id}/ulasim-cozumleri")]
        public async Task<IActionResult> GetUlasimCozumleri(int id)
        {
            var ulasim = await _context.UlasimCozumleri
                                        .Where(x => x.sehir_id == id)
                                        .ToListAsync();

            if (ulasim == null || ulasim.Count == 0)
            {
                return NotFound(new { message = "Ulaşım çözümleri bulunamadı" });
            }

            return Ok(ulasim);
        }
    }
}
