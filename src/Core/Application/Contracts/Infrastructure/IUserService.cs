using Kultura.Application.DTOs.Auth;

namespace Kultura.Application.Contracts.Infrastructure;

public interface IUserService
{
    Task<CreateUserResponse> CreateUser(CreateUserRequest request, string creatorUserId);
}