using System;

namespace FlightFinder.Shared
{
    public class SearchCriteria
    {
        public string FromAirport { get; set; } = string.Empty;
        public string ToAirport { get; set; } = string.Empty;
        public DateTime OutboundDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public TicketClass TicketClass { get; set; }

        public SearchCriteria()
        {
        }

        public SearchCriteria(string fromAirport, string toAirport)
        {
            FromAirport = fromAirport;
            ToAirport = toAirport;
            OutboundDate = DateTime.Today;
            ReturnDate = DateTime.Today.AddDays(7);
        }
    }
}
