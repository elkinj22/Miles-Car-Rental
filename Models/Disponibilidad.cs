namespace Miles_Car_Rental.Models
{
    public class Disponibilidad
    {
        public int id_disponibilidad { get; set; }
        public int id_vehiculoUbicacion { get; set; }
        public int id_localidad { get; set; }
        public bool disponible { get; set; }
    }
}
