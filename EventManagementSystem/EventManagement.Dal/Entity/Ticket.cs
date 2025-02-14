namespace EventManagement.Dal.Entity;

public class Ticket
{
    public long TicketId { get; set; }
    public long EventId { get; set; }
    public long UserId { get; set; }
    public double Price { get; set; }
    public int SeatNumber { get; set; }
    public Payment Payment { get; set; }
}
