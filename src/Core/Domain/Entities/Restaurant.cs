using Kultura.Domain.Entities.Common;

namespace Kultura.Domain.Entities;

public class Restaurant : BaseAuditableEntity
{
    public string Name { get; set; }
    public virtual ICollection<Branch> Branches { get; set; } 
}