using AuctionBusiness.Dtos;
using AuctionDataAccess.Domain;
using AuctionDataAccess.Models;
using AutoMapper;

namespace AuctionCore.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateVehicleDTO,Vehicle>().ReverseMap();
        CreateMap<UpdateVehicleDTO,Vehicle>().ReverseMap();
    }
}
