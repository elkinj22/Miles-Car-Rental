using Miles_Car_Rental.Models;

namespace Miles_Car_Rental.Services
{
    public class DisponibilidadService
    {
        private List<Disponibilidad> disponibilidad = new List<Disponibilidad>()
            {
                new Disponibilidad { id_disponibilidad = 1, id_vehiculoUbicacion = 1, id_localidad = 1, disponible = true },
                new Disponibilidad { id_disponibilidad = 2, id_vehiculoUbicacion = 2, id_localidad = 1, disponible = true },
                new Disponibilidad { id_disponibilidad = 3, id_vehiculoUbicacion = 3, id_localidad = 2, disponible = true },
                new Disponibilidad { id_disponibilidad = 4, id_vehiculoUbicacion = 4, id_localidad = 2, disponible = true }
            };

        public Disponibilidad GetDisponibilidad(int id)
        {
            return disponibilidad.FirstOrDefault(x => x.id_disponibilidad == id);
        }   
        public dynamic GetDisponibilidades()
        {

            return disponibilidad;
        }
    }
}
