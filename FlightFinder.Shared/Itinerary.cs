namespace FlightFinder.Shared
{
    public class Itinerary
    {
        public FlightSegment Outbound { get; set; }
        public FlightSegment Return { get; set; }
        public decimal Price { get; set; }
        public decimal TotalDurationHours => Outbound.DurationHours + Return.DurationHours;
        public string AirlineName => Outbound?.Airline ?? string.Empty;
    }
}
