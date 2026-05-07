namespace ReservaHotelTpi.Models
{
    public class Pago
    {
        public int Id { get; set; }
        public string Metodo { get; set; }

        public float Monto { get; set; }

        public DateTime Fecha { get; set; }
        public bool State { get; set; }

        public int ReservaId { get; set; }
    }
}
