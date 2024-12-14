using AuctionBusiness.Dtos;
using AuctionCore.Models;

namespace AuctionBusiness.Abstraction;

public interface IPaymentHistoryService
{
    Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model);
    Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId);
}
