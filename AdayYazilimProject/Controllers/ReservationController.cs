using Business.Abstract;
using Entities.Dtos.Reservation.Request;
using Microsoft.AspNetCore.Mvc;

namespace AdayYazilimProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        public IReservationService _reservationService;

        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpPost]
        public IActionResult Reservation(ReservationRequestDto reservationRequestDto)
        {
            var reservationDto = _reservationService.Reservations(reservationRequestDto);
            if(reservationDto != null)
            {
                return Ok(reservationDto);
            }
            else
            {
                return BadRequest(reservationDto);
            }
        }
    }
}
