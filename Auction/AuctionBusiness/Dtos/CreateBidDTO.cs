using AuctionDataAccess.Domain;
using AuctionDataAccess.Models;
using System.Text.Json.Serialization;

namespace AuctionBusiness.Dtos;

public class CreateBidDTO
{
    public decimal BidAmount { get; set; }
    public DateTime BidDate { get; set; }
    public string BidStatus { get; set; }
    public string? UserId { get; set; }
    public int VehicleId { get; set; }
}
