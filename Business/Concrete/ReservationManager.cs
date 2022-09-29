using Business.Abstract;
using Entities.Dtos.Reservation.Request;
using Entities.Dtos.Reservation.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ReservationManager : IReservationService
    {
        public ReservationResponseDto Reservations(ReservationRequestDto reservationRequestDto)
        {
            if(reservationRequestDto.CouldItBeDifferent == true)
            {
                List<TicketDetails> ticketDetails = new List<TicketDetails>();

                var numberOfTicketPerson = reservationRequestDto.NumberOfTickets;

                foreach(var items in reservationRequestDto.Train.Cars)
                {
                    var currentOccupancy = Math.Ceiling((double)items.NumberOfTicketsPurchased / items.CarsCapacity * 100 );
                    var maxTicketNumber = (double)70 * items.CarsCapacity / 100;
                    var maxTicket = Math.Floor((double)maxTicketNumber - items.NumberOfTicketsPurchased);

                    if(maxTicket < 0)
                    {
                        continue;
                    }
                    else if(maxTicket - numberOfTicketPerson <= 0)
                    {
                        ticketDetails.Add(new TicketDetails { numberPersons = numberOfTicketPerson, CarsName = items.CarsName });
                        ReservationResponseDto reservationResponseDto = new ReservationResponseDto { ReservationAvailable = true, TicketDetail = ticketDetails };
                        return reservationResponseDto;
                    }
                    else
                    {
                        ticketDetails.Add(new TicketDetails { numberPersons = (int)maxTicket, CarsName = items.CarsName });
                        numberOfTicketPerson -= (int)maxTicket;
                    }   
                }
                if(numberOfTicketPerson <= 0)
                {
                    return new ReservationResponseDto { ReservationAvailable = true, TicketDetail = ticketDetails };
                } 
                else
                {
                    return new ReservationResponseDto { ReservationAvailable = false, TicketDetail = ticketDetails };
                }
            }
            else
            {

                foreach(var items in reservationRequestDto.Train.Cars)
                {
                    var currentOccupancy = (float)(items.NumberOfTicketsPurchased + reservationRequestDto.NumberOfTickets) / (items.CarsCapacity) * 100;
                    
                    if(currentOccupancy < 70)
                    {
                        List<TicketDetails> ticketDetails = new() { new TicketDetails { numberPersons = reservationRequestDto.NumberOfTickets, CarsName = items.CarsName } };
                        ReservationResponseDto reservationResponseDto = new() { ReservationAvailable = true, TicketDetail = ticketDetails };
                        return reservationResponseDto;
                    }
                }
                return new ReservationResponseDto { ReservationAvailable = false, TicketDetail = new List<TicketDetails>() };
            }
        }

    }
}
