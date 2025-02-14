namespace EventManagement.Dal.Entity;

public class User
{
    public long UserId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public long EventId { get; set; }
    public Event Event { get; set; }
    public ICollection<FeedBack> FeedBacks { get; set; }
    public ICollection<Event> Events { get; set; }
}
