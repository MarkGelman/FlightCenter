using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class AirlineCompany:IPoco
    {
        long Id { get; set; }
        string Name { get; set; }
        long CountryId { get; set; }
        long UserId { get; set; }

        User user;
        Ticket ticket;

        public AirlineCompany()
        {

        }

        public AirlineCompany(long id, string name, long countryId, long userId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
            UserId = userId;
        }
    }
}
