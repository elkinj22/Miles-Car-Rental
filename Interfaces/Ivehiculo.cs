using Miles_Car_Rental.Models;

namespace Miles_Car_Rental.Interfaces
{
    public interface Ivehiculo
    {
        Vehiculo GetVehiculo(int id);
        IEnumerable<Vehiculo> GetVehiculos();
        void AddVehiculo(Vehiculo vehiculo);
        void UpdateVehiculo(Vehiculo vehiculo);
        void DeleteVehiculo(int id);
      

    }
}
