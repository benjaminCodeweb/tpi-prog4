namespace ReservaHotelTpi.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public bool State { get; set; }
        public DateTime FechaSalida { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Cantidad { get; set; }
        public float SubTotal {get; set; }

        public int HabitacionId { get; set; }

       
    }
}
