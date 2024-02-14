namespace Miles_Car_Rental.Models
{
    public class Vehiculo
    {
        public int id { get; set; }
        public required string marca { get; set; }
        public required string modelo { get; set; }
        public int anio { get; set; }
        public required string color { get; set; }
        public required string placa { get; set; }
    }
}
