namespace Miles_Car_Rental.Models
{
    public class Devolucion
    {
        public int id_devolucion { get; set; }
        public int id_reserva { get; set; }
        public int id_localidad { get; set; }
        public required string fecha_devolucion { get; set; }
        public required string hora_devolucion { get; set; }
        public int km_devolucion { get; set; }
        public string? estado_devolucion { get; set; }
    }
}
