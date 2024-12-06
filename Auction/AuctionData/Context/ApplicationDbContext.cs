using AuctionDataAccess.Domain;
using AuctionDataAccess.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuctionDataAccess.Context;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<PaymentHistory> PaymentHistories { get; set; }
}
