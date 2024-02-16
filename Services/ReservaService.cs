using Miles_Car_Rental.Interfaces;
using Miles_Car_Rental.Models;
namespace Miles_Car_Rental.Services
{
    public class ReservaService : Ireserva

    {
        private List<Reserva> reservas = new List<Reserva>()
            {
                new Reserva { id_reserva = 1, id_vehiculo = 1, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021") },
                new Reserva { id_reserva = 2, id_vehiculo = 2, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021")},
                new Reserva { id_reserva = 3, id_vehiculo = 3, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021") },
                new Reserva { id_reserva = 4, id_vehiculo = 4, fecha_reserva = DateOnly.Parse("2021/10/01"), fecha_recogida = DateOnly.Parse("2021-10-02"), Fecha_Devolucion = DateOnly.Parse("2021/10/03")}
            };

        public Reserva GetReserva(int id)
        {
            return reservas.FirstOrDefault(x => x.id_reserva == id);
        }
        public IEnumerable<Reserva> GetReservas()
        {
            return reservas;
        }
        public void AddReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
        public void UpdateReserva(Reserva reserva)
        {
            var index = reservas.FindIndex(x => x.id_reserva == reserva.id_reserva);
            reservas[index] = reserva;
        }
        public void DeleteReserva(int id)
        {
            var index = reservas.FindIndex(x => x.id_reserva == id);
            reservas.RemoveAt(index);
        }

    }
}
