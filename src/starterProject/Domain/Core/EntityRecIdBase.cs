using NArchitecture.Core.Persistence.Repositories;
using System.ComponentModel.DataAnnotations;

public class EntityRecIdBase : Entity<Guid>
{
    [Key]
    public Guid RecId { get; set; }

    public bool Deleted { get; set; } = false;
}