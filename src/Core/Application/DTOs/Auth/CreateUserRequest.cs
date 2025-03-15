namespace Kultura.Application.DTOs.Auth;

public class CreateUserRequest
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public int? BranchId { get; set; }
    public int? RestaurantId { get; set; }
}