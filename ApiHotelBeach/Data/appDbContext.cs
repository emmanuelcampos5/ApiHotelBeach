using ApiHotelBeach.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.Hosting;

namespace ApiHotelBeach.Data
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options) : base(options)
        {

        }

        public DbSet<Paquete> Paquete { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }


}
