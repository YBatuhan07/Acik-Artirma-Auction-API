using AuctionBusiness.Abstraction;
using AuctionBusiness.Dtos;
using AuctionCore.Models;
using AuctionDataAccess.Context;
using AuctionDataAccess.Domain;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace AuctionBusiness.Concrete;

public class VehicleService : IVehicleService
{
    private readonly ApplicationDbContext _context;
    private readonly IMapper _mapper;
    private ApiResponse _response;

    public VehicleService(ApplicationDbContext context, IMapper mapper, ApiResponse response)
    {
        _context = context;
        _mapper = mapper;
        _response = response;
    }

    public async Task<ApiResponse> ChangeVehicleStatus(int vehicleId)
    {
        var result = await _context.Vehicles.FindAsync(vehicleId);
        if(result == null)
        {
            _response.IsSuccess = false;
            return _response;
        }
        else
        {
            result.IsActive = false;
            _response.IsSuccess = true;
            await _context.SaveChangesAsync();
            return _response;
        }
    }

    public async Task<ApiResponse> CreateVehicle(CreateVehicleDTO model)
    {
        if(model != null)
        {
            var objDTO = _mapper.Map<Vehicle>(model);
            if(objDTO != null)
            {
                _context.Vehicles.Add(objDTO);
                if(await _context.SaveChangesAsync() > 0)
                {
                    _response.IsSuccess = true;
                    _response.Result = model;
                    _response.StatusCode = System.Net.HttpStatusCode.Created;
                    return _response;
                }
            }
        }
        _response.IsSuccess = false;
        _response.ErrorMessages.Add("Oooops! Something went wrong");
        return _response;
    }

    public async Task<ApiResponse> DeleteVehicle(int vehicleId)
    {
        // Check
        var result = await _context.Vehicles.FindAsync(vehicleId);
        if(result != null)
        {
            _context.Vehicles.Remove(result);
            if(await _context.SaveChangesAsync() > 0)
            {
                _response.IsSuccess = true;
                return _response;
            }
        }
        _response.IsSuccess = false;
        return _response;
    }
    public async Task<ApiResponse> GetVehicleById(int vehicleId)
    {
        var result = await _context.Vehicles.Include(x=>x.Seller).FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
        if(result != null)
        {
            _response.Result = result;
            _response.IsSuccess=true;
            return _response;
        }
        _response.IsSuccess = false;
        return _response;
    }

    public async Task<ApiResponse> GetVehicle()
    {
        var vehicle = await _context.Vehicles.Include(x=>x.Seller).ToListAsync();
        if(vehicle != null)
        {
            _response.IsSuccess = true;
            _response.Result =vehicle;
            return _response;
        }
        _response.IsSuccess = false;
        return _response;
    }


    public async Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDTO model)
    {
        var result = await _context.Vehicles.FindAsync(vehicleId);
        if( result != null)
        {
            Vehicle objDTO = _mapper.Map(model,result);
            if(await _context.SaveChangesAsync()> 0)
            {
                _response.IsSuccess = true;
                _response.Result = objDTO;
                return _response;
            }
        }
        _response.IsSuccess = false;
        return _response;
    }
}
