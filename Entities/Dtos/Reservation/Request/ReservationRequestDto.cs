using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Reservation.Request
{
    public class ReservationRequestDto
    {
        public Trains Train { get; set; }
        public int NumberOfTickets { get; set; }
        public bool CouldItBeDifferent { get; set; }
    }
}
