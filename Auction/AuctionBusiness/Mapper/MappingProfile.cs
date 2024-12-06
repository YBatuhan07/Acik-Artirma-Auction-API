using AuctionBusiness.Dtos;
using AuctionDataAccess.Models;
using AutoMapper;

namespace AuctionCore.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<RegisterRequestDTO,ApplicationUser>().ReverseMap();
    }
}
