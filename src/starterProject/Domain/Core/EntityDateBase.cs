
public class EntityDateBase : EntityRecIdBase
{
    public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedDate { get; set; }
}