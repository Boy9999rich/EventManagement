namespace EventManagement.Dal.Entity;

public class Payment
{
    public long PaymentId { get; set; }
    public long TicketId { get; set; }
    public Ticket Ticket { get; set; }
    public double Amount { get; set; }
    public string Status { get; set; }
}
