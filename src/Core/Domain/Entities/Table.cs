using System.ComponentModel.DataAnnotations.Schema;
using Kultura.Domain.Entities.Common;

namespace Kultura.Domain.Entities;

public class Table : BaseEntity
{
    public int TableNumber { get; set; }
    public int MaxCapacity { get; set; }
    public TableAttribute Attributes { get; set; }
}