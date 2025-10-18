namespace FlightFinder.Shared
{
    public enum TicketClass
    {
        Economy,
        PremiumEconomy,
        Business,
        First
    }

    public static class TicketClassExtensions
    {
        public static string ToDisplayString(this TicketClass ticketClass)
        {
            return ticketClass switch
            {
                TicketClass.Economy => "Economy",
                TicketClass.PremiumEconomy => "Premium Economy",
                TicketClass.Business => "Business",
                TicketClass.First => "First",
                _ => ticketClass.ToString()
            };
        }
    }
}
