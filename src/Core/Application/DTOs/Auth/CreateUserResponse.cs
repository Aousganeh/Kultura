namespace Kultura.Application.DTOs.Auth;

public class CreateUserResponse
{
    public string UserId { get; set; }
    public string Email { get; set; }
    public string BranchId { get; set; }
    public string Message { get; set; }
}