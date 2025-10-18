using System;

namespace FlightFinder.Shared
{
    public class FlightSegment
    {
        public string Airline { get; set; } = string.Empty;
        public TicketClass TicketClass { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ReturnTime { get; set; }
        public string FromAirportCode { get; set; } = string.Empty;
        public string ToAirportCode { get; set; } = string.Empty;
        public decimal DurationHours { get; set; }
    }
}
