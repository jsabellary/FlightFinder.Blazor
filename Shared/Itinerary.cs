namespace FlightFinder.Shared
{
    public class Itinerary
    {
        public FlightSegment Outbound { get; set; }
        public FlightSegment Return { get; set; }
        public decimal Price { get; set; }
        public string AirlineName { get; set; }
        public int TotalDurationHours { get; set; }
    }
}
