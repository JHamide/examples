public class TicketService
{
    public void Get(string ticketType, Action<string> getTicket)
    {
        //if (ticketType == "Movie")
        //    return new ...();
        //else if (ticketType == "Concert")
        //    return new ...();
        //else if (ticketType == "Flight")
        //    return new ...();
        //else
        //    throw new ArgumentException("Invalid ticket type.");
        getTicket(ticketType);
    }
}
