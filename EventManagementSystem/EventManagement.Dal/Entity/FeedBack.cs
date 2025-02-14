namespace EventManagement.Dal.Entity;

public class FeedBack
{
    public long FeedBackId { get; set; }
    public long EventId { get; set; }
    public long UserId { get; set; }
    public User User { get; set; }
    public string Rating { get; set; }
    public string Comment { get; set; }
}
