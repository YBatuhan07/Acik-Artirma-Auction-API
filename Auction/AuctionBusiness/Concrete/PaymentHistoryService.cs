using AuctionBusiness.Abstraction;
using AuctionBusiness.Dtos;
using AuctionCore.Models;
using AuctionDataAccess.Context;
using AuctionDataAccess.Domain;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuctionBusiness.Concrete;

public class PaymentHistoryService : IPaymentHistoryService
{
    private ApiResponse _response;
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    public PaymentHistoryService(ApiResponse response, ApplicationDbContext context, IMapper mapper)
    {
        _response = response;
        _context = context;
        _mapper = mapper;
    }

    public async Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId)
    {
        var response = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
        if (response != null)
        {
            _response.IsSuccess = true;
            _response.Result = response;
            return _response;
        }
        _response.IsSuccess = false;
        return _response;
    }

    public async Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model)
    {
        if (model == null)
        {
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Model is not include some fields");
            return _response;
        }
        else
        {
            var objDTO = _mapper.Map<PaymentHistory>(model);
            objDTO.PayDate = DateTime.Now;
            objDTO.IsActive = true;
            _context.PaymentHistories.Add(objDTO);
            if (await _context.SaveChangesAsync() > 0)
            {
                _response.IsSuccess = true;
                _response.Result = model;
                return _response;

            }
            _response.IsSuccess = false;
            _response.ErrorMessages.Add("Ooops! something went wrong!");
            return _response;

        }


    }
}
