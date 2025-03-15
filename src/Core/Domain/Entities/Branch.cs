namespace Kultura.Domain.Entities;

public class Branch
{
    public string Name { get; set; }
    public string Location { get; set; }
    public int RestaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
    public virtual ICollection<ApplicationUser> Staff { get; set; }
}