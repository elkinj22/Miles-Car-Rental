using Microsoft.AspNetCore.Mvc;
using Miles_Car_Rental.Interfaces;
using Miles_Car_Rental.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;


namespace Miles_Car_Rental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehiculoController : ControllerBase
    {

        private readonly Ivehiculo _vehiculoService;
        private readonly Iconsultas _consultasService;

        public VehiculoController(Ivehiculo vehiculoService, Iconsultas consultasService)
        {
            _vehiculoService = vehiculoService;
            _consultasService = consultasService;
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult AddVehiculo(Vehiculo vehiculo)
        {
            _vehiculoService.AddVehiculo(vehiculo);
            return Ok("Vehiculo agregado");
        }
        [HttpGet]
        [Route("obtener")]
        public IActionResult GetVehiculos()
        {
            return Ok(_vehiculoService.GetVehiculos());
        }

        [HttpPost]
        [Route("reservar")]
        public dynamic ReservarVehiculo(Vehiculo vehiculo)
        {

            return new
            {
                sucess = true,
                message = "Vehiculo reservado",
                
            };


        }
        [HttpGet]
        [Route("disponibles")]
        public dynamic VehiculosDisponibles()
        {
            
            return _consultasService.ConsultarDisponibles();
        }   
    }
    
}
