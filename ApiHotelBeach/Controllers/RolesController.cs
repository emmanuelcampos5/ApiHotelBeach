using ApiHotelBeach.Data;
using ApiHotelBeach.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotelBeach.Controllers
{
    [Route("api/roles")]
    [ApiController]
    public class RolesController : Controller
    {             
            private readonly appDbContext _context;

            public RolesController(appDbContext appDbContext)
            {
                _context = appDbContext;
            }

            [HttpGet]
            public IEnumerable<Roles> GetRoles()
            {
                return _context.Roles.ToList();
            }

            [HttpGet("{id}")]
            public Roles getRoles(int id)
            {
                return this._context.Roles.Find(id);
            }
        
    }
}
