using NArchitecture.Core.Persistence.Repositories;
using System.ComponentModel.DataAnnotations;

public class EntityRecIdBase : Entity<Guid>
{
    public int RecId { get; set; }

    public bool Deleted { get; set; } = false;
}