using Microsoft.EntityFrameworkCore;
using UlasimAPI.Models;

namespace UlasimAPI.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }

        public DbSet<Sehir> Sehirler { get; set; }
        public DbSet<UlasimCozumleri> UlasimCozumleri { get; set; }
    }
}
