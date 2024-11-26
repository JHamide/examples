public class TicketService
{
    public void Get(string ticketType)
    {
        if (ticketType == "Movie")
            new MovieTicketService().GetTicket(ticketType);
        else if (ticketType == "Concert")
            new ConcertTicketService().GetTicket(ticketType);
        else if (ticketType == "Flight")
            new FlightTicketService().GetTicket(ticketType);
        else
            throw new ArgumentException("Invalid ticket type.");
    }
}


public interface ITicketService
{
    public void GetTicket(string type);
}

public interface IMovieTicketService : ITicketService
{
}

public interface IConcertTicketService : ITicketService
{
}

public interface IFlightTicketService : ITicketService
{
}

public class MovieTicketService : IMovieTicketService
{
    public void GetTicket(string type)
    {
        throw new NotImplementedException();
    }
}

public class ConcertTicketService : IConcertTicketService
{
    public void GetTicket(string type)
    {
        throw new NotImplementedException();
    }
}

public class FlightTicketService : IFlightTicketService
{
    public void GetTicket(string type)
    {
        throw new NotImplementedException();
    }
}
