using Miles_Car_Rental.Data;
using Miles_Car_Rental.Interfaces;

namespace Miles_Car_Rental.Services
{
    public class ConsultasService : Iconsultas
    {

        private readonly Ivehiculo _vehiculoService;
        private readonly Ireserva _reservaService;

        public ConsultasService(Ivehiculo vehiculoService, Ireserva reservaService)
        {
            _vehiculoService = vehiculoService;
            _reservaService = reservaService;
        }

       

        public dynamic ConsultarDisponibles()
        {
            var Vehiculo = _vehiculoService.GetVehiculos();
            var Reserva = _reservaService.GetReservas();

            var lis = from v in Vehiculo
                      join r in Reserva on v.id equals r.id_vehiculo
                      select new
                      {
                          id = v.id,
                          marca = v.marca,
                          modelo = v.modelo,
                          anio = v.anio,
                          color = v.color,
                          placa = v.placa,
                          fecha_reserva = r.fecha_reserva,
                          fecha_entrega = r.fecha_recogida,
                          fecha_devolucion = r.Fecha_Devolucion
                      };

            return lis;
        }




    }
}

