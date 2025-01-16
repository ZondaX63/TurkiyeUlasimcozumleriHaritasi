using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UlasimAPI.Data;
using UlasimAPI.Models;

namespace UlasimAPI.Controllers
{
    [Route("api/ulasim-cozumleri")]
    [ApiController]
    public class UlasimController : ControllerBase
    {
        private readonly MyDbContext _context;

        public UlasimController(MyDbContext context)
        {
            _context = context;
        }

        // Belirli bir şehir için ulaşım çözümleri al
        [HttpGet("{sehirId}")]
        public async Task<ActionResult<IEnumerable<UlasimCozumleri>>> GetBySehir(int sehirId)
        {
            var ulasim = await _context.UlasimCozumleri
                                        .Where(u => u.sehir_id == sehirId)
                                        .ToListAsync();

            if (ulasim == null || ulasim.Count == 0)
            {
                return NotFound();
            }

            return Ok(ulasim);
        }
    }
}
