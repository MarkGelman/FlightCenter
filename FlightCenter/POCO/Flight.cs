using System;
using System.Collections.Generic;
using System.Text;

namespace FlightCenter.POCO
{
    class Flight : IPoco
    {
        long Id {get;set;}
        long AirlineCompanyId { get; set; }
        long OriginCountryId { get; set; }
        long DestinationCountryId { get; set; }
        DateTime  DepartureTime { get; set; }
        DateTime LandingTime { get; set; }
        int RemainingTickets { get; set; }

        AirlineCompany airlineCompany;
        Country country;
        
        public Flight()
        {

        }

        public Flight(int id, long airlineCompanyId, long originCountryId,long destinationCountryId, DateTime departureTime,
                        DateTime landingTime, int remainingTickets)
        {
            Id = id;
            AirlineCompanyId = airlineCompanyId;
            OriginCountryId = originCountryId;
            DestinationCountryId = destinationCountryId;
            DepartureTime = departureTime;
            LandingTime = landingTime;
            RemainingTickets = remainingTickets;
        }


    }
}
