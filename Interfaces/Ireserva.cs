using Miles_Car_Rental.Models;

namespace Miles_Car_Rental.Interfaces
{
    public interface Ireserva
    {
        Reserva GetReserva(int id);
        IEnumerable<Reserva> GetReservas();
        void AddReserva(Reserva reserva);
        void UpdateReserva(Reserva reserva);
        void DeleteReserva(int id); 
    }
}
