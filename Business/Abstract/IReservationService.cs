using Entities.Dtos.Reservation.Request;
using Entities.Dtos.Reservation.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IReservationService
    {
        public ReservationResponseDto Reservations(ReservationRequestDto reservationRequestDto);
    }
}
