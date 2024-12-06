using AuctionBusiness.Dtos;
using AuctionCore.Models;

namespace AuctionBusiness.Abstraction;

public interface IUserService
{
    Task<ApiResponse> Register(RegisterRequestDTO model);
    Task<ApiResponse> Login(LoginRequestDTO model);
}
