using AuctionDataAccess.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AuctionDataAccess.Domain;

public class PaymentHistory
{
    [Key]
    public int PaymentId { get; set; }
    public bool IsActive { get; set; }
    public string ClientSecret { get; set; }
    public string StripePaymentIntentId { get; set; }
    public DateTime PayDate { get; set; }
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
    public int VehicleId { get; set; }
    [JsonIgnore]
    public Vehicle Vehicle { get; set; }

}
