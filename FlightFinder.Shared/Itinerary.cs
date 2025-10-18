namespace FlightFinder.Shared
{
    public class Itinerary
    {
        public FlightSegment Outbound { get; set; } = new FlightSegment();
        public FlightSegment Return { get; set; } = new FlightSegment();
        public decimal Price { get; set; }
        public decimal TotalDurationHours => Outbound.DurationHours + Return.DurationHours;
        public string AirlineName => Outbound.Airline;
    }
}
