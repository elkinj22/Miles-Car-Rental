using Miles_Car_Rental.Interfaces;
using Miles_Car_Rental.Models;

namespace Miles_Car_Rental.Services
{
    public class VehiculoService : Ivehiculo
    {
        private List<Vehiculo> _vehiculos = new List<Vehiculo>()
        {
            new Vehiculo {id = 1, marca = "Toyota", modelo = "Corolla", anio = 2019, color = "Blanco", placa = "P-001"},
            new Vehiculo {id = 2, marca = "Honda", modelo = "Civic", anio = 201,color = "rojo", placa = "P-002"},
            new Vehiculo {id = 3, marca = "Nissan", modelo = "Sentra", anio = 2018, color = "Azul", placa = "P-003"},

        };

        //private readonly List  <Vehiculo> _vehiculos = new List<Vehiculo>();    
        public Vehiculo GetVehiculo(int id)
        {
            return _vehiculos.FirstOrDefault(x => x.id == id);
        }
        public IEnumerable<Vehiculo> GetVehiculos()
        {
            return _vehiculos;
        }
        public void AddVehiculo(Vehiculo vehiculo)
        {
            _vehiculos.Add(vehiculo);
        }

        public void UpdateVehiculo(Vehiculo vehiculo)
        {
            var index = _vehiculos.FindIndex(x => x.id == vehiculo.id);
            _vehiculos[index] = vehiculo;
        }
        public void DeleteVehiculo(int id)
        {
            var index = _vehiculos.FindIndex(x => x.id == id);
            _vehiculos.RemoveAt(index);
        }

    }
}
