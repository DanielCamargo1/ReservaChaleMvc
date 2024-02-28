using Microsoft.EntityFrameworkCore;
using ReservaDeChaleMvc.Models;

namespace ReservaDeChaleMvc.Data
{
    public class ReservaDbContext :DbContext
    {
        public ReservaDbContext(DbContextOptions<ReservaDbContext> options) : base(options)
        {

        }

        public DbSet<ChaleModel> Reserve { get; set; }
        public DbSet<LoginModel> User { get; set; }
    }
}
