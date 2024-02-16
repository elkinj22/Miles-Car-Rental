using Microsoft.AspNetCore.Mvc;
using Miles_Car_Rental.Interfaces;
using Miles_Car_Rental.Models;

namespace Miles_Car_Rental.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservaController: ControllerBase
    {
        private readonly Ireserva _reservaService;
        
        public ReservaController(Ireserva reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost]
        [Route("agregar")]
        public IActionResult AddReserva(Reserva reserva)
        {
            _reservaService.AddReserva(reserva);
            return Ok("Reserva agregada");
        }
        [HttpGet]
        [Route("obtener")]
        public IActionResult GetReservas()
        {
            return Ok(_reservaService.GetReservas());
        }
        [HttpGet]
        [Route("obtener/{id}")]
        public IActionResult GetReserva(int id)
        {
            return Ok(_reservaService.GetReserva(id));
        }

    }
}
