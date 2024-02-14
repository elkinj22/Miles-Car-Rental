namespace Miles_Car_Rental.Models
{
    public class Reserva
    {
        public int id_reserva { get; set; }
        public int id_cliente { get; set; }
        public int id_vehiculo { get; set; }
        public DateOnly fecha_recogida { get; set; }
        public TimeOnly hora_recogida { get; set; }
        public DateOnly Fecha_Devolucion { get; set; }
        public TimeOnly hora_devolucion{ get; set; }
        public  string? lugar_entrega { get; set; }
        public  string? lugar_devolucion { get; set; }
        public  string? estado { get; set; }
        public DateOnly fecha_reserva { get; internal set; }
    }
}
