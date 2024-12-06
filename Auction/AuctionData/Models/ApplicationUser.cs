using AuctionDataAccess.Domain;
using Microsoft.AspNetCore.Identity;

namespace AuctionDataAccess.Models;

public class ApplicationUser : IdentityUser
{
    public string? FullName { get; set; }
    public string? ProfilePicture { get; set; }
    public DateTime DateOfBirth { get; set; }

    public ICollection<PaymentHistory> PaymentHistories { get; set; }
    public ICollection<Vehicle> Vehicles { get; set; }
    public ICollection<Bid> Bids { get; set; }
}
