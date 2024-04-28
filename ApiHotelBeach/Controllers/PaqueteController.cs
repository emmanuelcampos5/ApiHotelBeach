using ApiHotelBeach.Data;
using ApiHotelBeach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiHotelBeach.Controllers
{
    [Route("api/paquetes")]
    [ApiController]
    public class PaqueteController : Controller
    {
        private readonly appDbContext _context;

        public PaqueteController(appDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpGet]
        public IEnumerable<Paquete> GetPaquete()
        {
            return _context.Paquete.ToList();
        }

        [HttpGet("{id}")]
        public Paquete getPaquete(int id)
        {
            return this._context.Paquete.Find(id);
        }
    }
}
