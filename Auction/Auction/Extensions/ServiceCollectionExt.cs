using AuctionBusiness.Abstraction;
using AuctionBusiness.Concrete;
using AuctionCore.MailHelper;
using AuctionCore.Models;

namespace Auction.Extensions;

public static class ServiceCollectionExt
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services,IConfiguration configuration)
    {
        #region services
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IVehicleService, VehicleService>();
        services.AddScoped<IBidService, BidService>();
        services.AddScoped<IMailService,MailService>();
        services.AddScoped(typeof(ApiResponse));
        #endregion
        return services;
    }
}
