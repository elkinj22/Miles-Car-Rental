using Microsoft.AspNetCore.Mvc;
using Miles_Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace Miles_Car_Rental.Controllers
{
    [ApiController]
    [Route("vehiculo")]
    public class VehiculoController : ControllerBase
    {
        [HttpGet]
        [Route("listar")]
        public dynamic listarVehiculo()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>()
            {
                new Vehiculo { id = 1, marca = "Toyota", modelo = "Corolla", anio = 2019, color = "Blanco", placa = "P-001ABC" },
                new Vehiculo { id = 2, marca = "Toyota", modelo = "Yaris", anio = 2018, color = "Gris", placa = "P-002DEF" },   
                new Vehiculo { id = 3, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"},
                new Vehiculo { id = 4, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"} 

            };
            return vehiculos;
        }

        [HttpGet]
        [Route("listardisponible")]
        public dynamic listarVehiculoDisponible()
        {
           List<Vehiculo> vehiculos = new List<Vehiculo>()
           {
                new Vehiculo { id = 1, marca = "Toyota", modelo = "Corolla", anio = 2019, color = "Blanco", placa = "P-001ABC" },
                new Vehiculo { id = 2, marca = "Toyota", modelo = "Yaris", anio = 2018, color = "Gris", placa = "P-002DEF" },   
                new Vehiculo { id = 3, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"},
                new Vehiculo { id = 4, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"} 

            };

            List<VehiculoUbicacion> vehiculoUbicacion = new List<VehiculoUbicacion>()
            {
                new VehiculoUbicacion { id_vehiculoUbicacion = 1, id_vehiculo = 1, id_localidad = 1 },
                new VehiculoUbicacion { id_vehiculoUbicacion = 2, id_vehiculo = 2, id_localidad = 1 },
                new VehiculoUbicacion { id_vehiculoUbicacion = 3, id_vehiculo = 3, id_localidad = 2 },
                new VehiculoUbicacion { id_vehiculoUbicacion = 4, id_vehiculo = 4, id_localidad = 2 }
            };  

            List<Disponibilidad> disponibilidad = new List<Disponibilidad>()
            {
                new Disponibilidad { id_disponibilidad = 1, id_vehiculoUbicacion = 1, id_localidad = 1, disponible = true },
                new Disponibilidad { id_disponibilidad = 2, id_vehiculoUbicacion = 2, id_localidad = 1, disponible = true },
                new Disponibilidad { id_disponibilidad = 3, id_vehiculoUbicacion = 3, id_localidad = 2, disponible = true },
                new Disponibilidad { id_disponibilidad = 4, id_vehiculoUbicacion = 4, id_localidad = 2, disponible = true }
            };

            List <Localidad> localidad = new List<Localidad>()
            {
                new Localidad { id_localidad = 1, nombre = "San Salvador" },
                new Localidad { id_localidad = 2, nombre = "Santa Ana" }
            };

            var lis  = from v in vehiculos
                        join vu in vehiculoUbicacion on v.id equals vu.id_vehiculo
                        join d in disponibilidad on vu.id_vehiculoUbicacion equals d.id_vehiculoUbicacion
                        join l in localidad on d.id_localidad equals l.id_localidad
                        where d.disponible == true
                        select new
                        {
                            id = v.id,
                            marca = v.marca,
                            modelo = v.modelo,
                            anio = v.anio,
                            color = v.color,
                            placa = v.placa,
                            localidad = l.nombre
                        };
            return lis;
        }

        [HttpPost]
        [Route("reservar")]
        public dynamic ReservarVehiculo(Vehiculo vehiculo)
        {
            int vehiculoId = 4;

            List<Vehiculo> vehiculos = new List<Vehiculo>()
            {
                new Vehiculo { id = 1, marca = "Toyota", modelo = "Corolla", anio = 2019, color = "Blanco", placa = "P-001ABC" },
                new Vehiculo { id = 2, marca = "Toyota", modelo = "Yaris", anio = 2018, color = "Gris", placa = "P-002DEF" },
                new Vehiculo { id = 3, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"},
                new Vehiculo { id = 4, marca = "Toyota", modelo = "Hilux", anio = 2020, color = "Gris", placa = "P-002DAA"}

            };

            List <Reserva> reservas = new List<Reserva>()
            {
                new Reserva { id_reserva = 1, id_vehiculo = 1, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021") },
                new Reserva { id_reserva = 2, id_vehiculo = 2, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021")},
                new Reserva { id_reserva = 3, id_vehiculo = 3, fecha_reserva =  DateOnly.Parse("10/01/2021"), fecha_recogida = DateOnly.Parse("10/02/2021"), Fecha_Devolucion = DateOnly.Parse("10/03/2021") },
                new Reserva { id_reserva = 4, id_vehiculo = 4, fecha_reserva = DateOnly.Parse("2021/10/01"), fecha_recogida = DateOnly.Parse("2021-10-02"), Fecha_Devolucion = DateOnly.Parse("2021/10/03")}
            };

            var lis = from v in vehiculos
                      join r in reservas on v.id equals r.id_vehiculo
                      where v.id == vehiculoId
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

            return new
            {
                sucess = true,
                message= "Vehiculo reservado",
                vehiculo = lis
            };
        }
    }
    
}
