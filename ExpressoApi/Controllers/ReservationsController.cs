using ExpressoApi.Models;
using ExpressoApi.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExpressoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private IReservation reservationRepository;

        public ReservationsController(IReservation aReservationRepository)
        {
            reservationRepository = aReservationRepository;
        }

        [HttpPost]
        public IActionResult AddReservation(Reservation reservation)
        {
            reservationRepository.AddReservation(reservation);
            return Ok(StatusCodes.Status200OK);
        }
    }
}