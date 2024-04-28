using ApiHotelBeach.Data;
using ApiHotelBeach.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiHotelBeach.Controllers
{
    [Route("api/clientes")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly appDbContext _context;

        public ClienteController(appDbContext appDbContext)
        {
            _context = appDbContext;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return _context.Cliente.ToList();
        }

        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            return this._context.Cliente.Find(id);
        }

        [HttpPost]
        public IActionResult Post(Cliente cliente)
        {
            try
            {
                this._context.Cliente.Add(cliente);
                this._context.SaveChanges();

                return Ok("Cliente agregado correctamente");
            }
            catch (Exception ex)
            {
                return NotFound("Error " + ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put(Cliente cliente)
        {
            try
            {
                _context.Cliente.Update(cliente);
                _context.SaveChanges();

                return Ok("El cliente fue actualizado correctamente");
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
                var temp = this._context.Cliente.Find(id);
                this._context.Cliente.Remove(temp);
                this._context.SaveChanges();

                return Ok("El cliente con ID: "+ id+ " fue eliminado correctamente");
            }
            catch(Exception ex)
            {
                return NotFound("Error " + ex.Message);
            }
        }
    }
}
