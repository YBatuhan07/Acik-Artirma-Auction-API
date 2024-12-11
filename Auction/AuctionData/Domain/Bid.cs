using AuctionDataAccess.Models;
using System.ComponentModel.DataAnnotations;
using AuctionDataAccess.Enums;
using System.Text.Json.Serialization;

namespace AuctionDataAccess.Domain;

public class Bid
{
    [Key]
    public int BidId { get; set; }
    public decimal BidAmount { get; set; }
    public DateTime BidDate { get; set; }
    public string BidStatus { get; set; } = AuctionDataAccess.Enums.BidStatus.Pending.ToString();
    public string? UserId { get; set; }
    [JsonIgnore]
    public ApplicationUser User { get; set; }
    public int VehicleId { get; set; }
    [JsonIgnore]
    public Vehicle Vehicle { get; set; }
}
