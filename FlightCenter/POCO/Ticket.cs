using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class Ticket:IPoco
    {
        long Id { get; set; }
        long FlightId { get; set; }
        long CustomerId { get; set; }

        Flight flight;
        Customer customer;
        public Ticket()
        {

        }

        public Ticket(long id, long flightId, long customerId)
        {
            Id = id;
            FlightId = flightId;
            CustomerId = customerId;
        }
    }
}
