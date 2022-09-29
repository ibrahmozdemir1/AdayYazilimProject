using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.Reservation.Response
{
    public class ReservationResponseDto
    {
        public bool ReservationAvailable { get; set; }
        public List<TicketDetails> TicketDetail { get; set; }

    }

    public class TicketDetails
    {
        public string CarsName { get; set; }
        public int numberPersons { get; set; }
    }
}
