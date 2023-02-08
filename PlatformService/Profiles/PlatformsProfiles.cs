using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformsProfile : Profile
    {
        public PlatformsProfile()
        {
            //Source -> Target
            //for reading the source is my platform model , 
            //and the target ( what gets out from the system to the consumer is the platform Dto)
            CreateMap<Platform, PlatformReadDto>();
            //for writing
            CreateMap<PlatformCreateDto, Platform>();

        }
    }
}