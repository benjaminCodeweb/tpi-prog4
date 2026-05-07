using Microsoft.AspNetCore.Identity;

namespace ReservaHotelTpi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nombre { get; set; }
        public string Apellido {  get; set; }
        public string Email { get; set; }
        public string NumberTel { get; set; 
        }
        public string passwordHash {  get; set; }

    }
}
