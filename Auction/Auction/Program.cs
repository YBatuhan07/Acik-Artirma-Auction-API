
using Auction.Extensions;
using AuctionBusiness.Abstraction;
using AuctionBusiness.Concrete;
using AuctionCore.Models;
using AuctionDataAccess.Context;
using AuctionDataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Auction
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddPersistenceLayer(builder.Configuration);
            builder.Services.AddApplicationLayer(builder.Configuration);
            builder.Services.AddSwaggerCollection(builder.Configuration);
            builder.Services.AddInfrastructureLayer(builder.Configuration);

            builder.Services.AddSwaggerGen();
            //builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseStaticFiles();
            app.MapControllers();

            app.Run();
        }
    }
}
