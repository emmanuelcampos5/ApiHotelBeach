using ApiHotelBeach.Data;
using ApiHotelBeach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiHotelBeach.Controllers
{
        [Route("api/reservas")]
        [ApiController]
        public class ReservaController : ControllerBase
        {
            private readonly appDbContext _context;

            public ReservaController(appDbContext appDbContext)
            {
                _context = appDbContext;
            }

            [HttpGet]
            public IEnumerable<Reserva> Get()
            {               
                return _context.Reserva.ToList();
            }

            [HttpGet("{id}")]
            public Reserva Get(int id)
            {
                return this._context.Reserva.Find(id);
            }

            [HttpPost]
            public IActionResult Post(Reserva reserva)
            {
                try
                {
                    this._context.Reserva.Add(reserva);
                    this._context.SaveChanges();

                    return Ok("Reserva agregada correctamente");
                }
                catch (Exception ex)
                {
                    return NotFound("Error " + ex.Message);
                }
            }

            [HttpPut]
            public IActionResult Put(Reserva reserva)
            {
                try
                {
                    _context.Reserva.Update(reserva);
                    _context.SaveChanges();

                    return Ok("La reserva se actualizo correctamente");
                }
                catch (Exception ex)
                {
                    return NotFound("Error " + ex.Message);
                }
            }

            [HttpDelete("{id}")]
            public IActionResult Delete(int id)
            {
                try
                {
                    var temp = this._context.Reserva.Find(id);
                    this._context.Reserva.Remove(temp);
                    this._context.SaveChanges();

                    return Ok("El cliente con ID: " + id + " fue eliminado correctamente");
                }
                catch (Exception ex)
                {
                    return NotFound("Error " + ex.Message);
                }
            }         
        }
}
