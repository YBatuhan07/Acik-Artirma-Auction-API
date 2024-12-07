using AuctionBusiness.Dtos;
using AuctionCore.Models;
using Microsoft.EntityFrameworkCore.Update.Internal;

namespace AuctionBusiness.Abstraction;

public interface IVehicleService
{
    Task<ApiResponse> CreateVehicle(CreateVehicleDTO model);
    Task<ApiResponse> GetVehicle();
    Task<ApiResponse> UpdateVehicleResponse(int vehicleId,UpdateVehicleDTO model);
    Task<ApiResponse> DeleteVehicle(int vehicleId);
    Task<ApiResponse> GetVehicleById(int vehicleId);
    Task<ApiResponse> ChangeVehicleStatus(int vehicleId);
}
