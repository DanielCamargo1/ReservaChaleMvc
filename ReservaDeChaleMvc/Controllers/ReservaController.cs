using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ReservaDeChaleMvc.Data;
using ReservaDeChaleMvc.Models;

namespace ReservaDeChaleMvc.Controllers
{
    public class ReservaController
    {
        private readonly ReservaDbContext _context;

        public ReservaController(ReservaDbContext context)
        {
            _context = context;
        }
        
    }
}
