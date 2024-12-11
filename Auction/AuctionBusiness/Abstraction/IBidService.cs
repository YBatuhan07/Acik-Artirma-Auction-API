using AuctionBusiness.Dtos;
using AuctionCore.Models;

namespace AuctionBusiness.Abstraction;

public interface IBidService
{
    Task<ApiResponse> CreateBid(CreateBidDTO model);
    Task<ApiResponse> UpdateBid(int bidId, UpdateBidDTO model);
    Task<ApiResponse> GetBidById(int bidId);
    Task<ApiResponse> CancelBid(int bidId);
    Task<ApiResponse> AutomaticallyCreateBid(CreateBidDTO model);
    Task<ApiResponse> GetBidByVehicleId(int vehicleId);

}
