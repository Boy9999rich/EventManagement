namespace EventManagement.Dal.Entity;

public class Event
{
    public long EventId { get; set; }
    public string Name { get; set; }
    public DateTime CreatedTime { get; set; }
    public string Location { get; set; }
    public long OrganizerId { get; set; }
    public User Organizer { get; set; }
    public ICollection<User> Users { get; set; }
}
