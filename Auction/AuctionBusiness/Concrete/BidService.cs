﻿using AuctionBusiness.Abstraction;
using AuctionBusiness.Dtos;
using AuctionCore.MailHelper;
using AuctionCore.Models;
using AuctionDataAccess.Context;
using AuctionDataAccess.Domain;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuctionBusiness.Concrete;

public class BidService : IBidService
{
    private readonly ApplicationDbContext context;
    private readonly IMapper mapper;
    private readonly ApiResponse response;
    private readonly IMailService _mailService;

    public BidService(ApplicationDbContext context, IMapper mapper, ApiResponse response,IMailService mailService)
    {
        this.context = context;
        this.mapper = mapper;
        this.response = response;
        this._mailService = mailService;
    }

    public async Task<ApiResponse> AutomaticallyCreateBid(CreateBidDTO model)
    {
        var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);
        if (!isPaid)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("Please before pay auction price");
            return response;
        }

        var result = await context.Bids.Where(x => x.VehicleId == model.VehicleId && x.Vehicle.IsActive == true).OrderByDescending(x => x.BidAmount).ToListAsync();
        if (result.Count == 0)
        {
            response.IsSuccess = false;
            return response;
        }
        var objDTO = mapper.Map<Bid>(model);
        objDTO.BidAmount = result[0].BidAmount + (result[0].BidAmount * 10) / 100;
        objDTO.BidDate = DateTime.Now;
        context.Bids.Add(objDTO);
        await context.SaveChangesAsync();
        response.IsSuccess = true;
        response.Result = result;
        return response;
    }

    public Task<ApiResponse> CancelBid(int bidId)
    {
        throw new NotImplementedException();
    }

    public async Task<ApiResponse> CreateBid(CreateBidDTO model)
    {
        var returnValue = await CheckIsActive(model.VehicleId);
        var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);
        if (returnValue.Price >= model.BidAmount)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("You should surpass the highest bid in the placed bids");
            return response;
        }
        //if (!isPaid)
        //{
        //    response.IsSuccess = false;
        //    response.ErrorMessages.Add("Please before pay auction price");
        //    return response;
        //}
        if (returnValue == null)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("This car is not active");
        }
        if (model != null)
        {
            var topPrice = await context.Bids.Where(x => x.VehicleId == model.VehicleId).OrderByDescending(x => x.BidAmount).ToListAsync();
            if (topPrice.Count != 0)
            {
                if (topPrice[0].BidAmount >= model.BidAmount)
                {
                    response.IsSuccess = false;
                    response.ErrorMessages.Add("Entry bid amount, not lower than higher price to the system;higher price is: " + topPrice[0].BidAmount);
                    return response;
                }
            }
            Bid bid = mapper.Map<Bid>(model);
            bid.BidDate = DateTime.Now;
            await context.Bids.AddAsync(bid);
            if(await context.SaveChangesAsync() > 0)
            {
                var userDetail = await context.Bids.Include(x=>x.User).Where(x=>x.UserId == model.UserId).FirstOrDefaultAsync();
                _mailService.SendEmail("Your bid is success","Your bid is:" + bid.BidAmount,bid.User.UserName);
                response.IsSuccess = true;
                response.Result = model;
                return response;
            }
        }
        response.IsSuccess = false;
        response.ErrorMessages.Add("Oops someting went wrong");
        return response;
    }

    public async Task<ApiResponse> GetBidByVehicleId(int vehicleId)
    {
        var obj = await context.Bids.Include(x => x.Vehicle).ThenInclude(x => x.Bids).Where(x => x.VehicleId == vehicleId).ToListAsync();
        if (obj != null)
        {
            response.IsSuccess = true;
            response.Result = obj;
            return response;
        }
        response.IsSuccess = false;
        return response;
    }

    public async Task<ApiResponse> GetBidById(int bidId)
    {
        var result = await context.Bids.Include(x => x.User).Where(x => x.BidId == bidId).FirstOrDefaultAsync();
        if (result == null)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("bid is not found");
            return response;
        }

        response.IsSuccess = true;
        response.Result = result;
        return response;

    }

    public async Task<ApiResponse> UpdateBid(int bidId, UpdateBidDTO model)
    {
        var isPaid = await CheckIsPaidAuction(model.UserId, model.VehicleId);
        if (!isPaid)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("Please before pay auction price");
            return response;
        }
        var result = await context.Bids.FindAsync(bidId);
        if (result == null)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("bid is not found");
            return response;
        }
        if (result.BidAmount < model.BidAmount && result.UserId == model.UserId)
        {
            var objDTO = mapper.Map(model, result);
            objDTO.BidDate = DateTime.Now;
            response.IsSuccess = true;
            response.Result = objDTO;
            await context.SaveChangesAsync();
            return response;
        }
        else if (result.BidAmount >= model.BidAmount)
        {
            response.IsSuccess = false;
            response.ErrorMessages.Add("You are not entry low price than your old bid amount,your older bid amount is : " + result.BidAmount);
            return response;
        }
        response.IsSuccess = false;
        response.ErrorMessages.Add("Something went wrong");
        return response;
    }

    private async Task<Vehicle> CheckIsActive(int vehicleId)
    {
        var obj = await context.Vehicles.Where(x => x.VehicleId == vehicleId && x.IsActive == true && x.EndTime >= DateTime.Now).FirstOrDefaultAsync();
        if (obj != null)
        {
            return obj;
        }
        return null;
    }

    private async Task<bool> CheckIsPaidAuction(string userId, int vehicleId)
    {
        var obj = await context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
        if (obj != null)
        {
            return true;
        }
        return false;
    }
}