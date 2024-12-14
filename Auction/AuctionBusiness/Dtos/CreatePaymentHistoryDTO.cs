using AuctionDataAccess.Models;

namespace AuctionBusiness.Dtos;

public class CreatePaymentHistoryDTO
{
    public string ClientSecret { get; set; }
    public string StripePaymentIntentId { get; set; }
    public string UserId { get; set; }
    public int VehicleId { get; set; }
}
