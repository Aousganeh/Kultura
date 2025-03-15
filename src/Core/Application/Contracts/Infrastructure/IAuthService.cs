using Kultura.Application.DTOs;
using Kultura.Application.DTOs.Auth;

namespace Kultura.Application.Contracts.Infrastructure;

public interface IAuthService
{
    Task<AuthResponse> Login(AuthRequest request);
}