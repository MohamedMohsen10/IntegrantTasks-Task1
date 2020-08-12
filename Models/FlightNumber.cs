using System;
using System.Collections.Generic;
using System.Text;

namespace Session_1_Task
{
    public class FlightNumber
    {
        public DateTime Departure { get; set; }
        public string Description { get; set; }
        public string Airline { get; set; }
        public virtual List<Flight> Flights { get; set; } = new List<Flight>();
        public Airport StartAirport { get; set; }
        public Airport DestinationAirport { get; set; }
        //public FlightNumber(Airport _startAirport, Airport _destinationAirport)
        //{
        //    StartAirport = _startAirport;
        //    DestinationAirport = _destinationAirport; 
        //}
        public FlightNumber()
        {

        }
    }
}
