namespace FlightFinder.Shared
{
    public class Itinerary
    {
        public FlightSegment Outbound { get; set; } = new FlightSegment();
        public FlightSegment Return { get; set; } = new FlightSegment();
        public decimal Price { get; set; }
        public decimal TotalDurationHours => (Outbound?.DurationHours ?? 0) + (Return?.DurationHours ?? 0);
        public string AirlineName => Outbound?.Airline ?? string.Empty;
    }
}
