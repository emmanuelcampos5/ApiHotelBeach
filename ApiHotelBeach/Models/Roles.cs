using System.ComponentModel.DataAnnotations;

namespace ApiHotelBeach.Models
{
    public class Roles
    {
        [Key]
        public int RoleID { get; set; }

        public string NombreRole { get; set; }
    }
}
