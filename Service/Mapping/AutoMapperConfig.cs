using AutoMapper;
using GroupMap.Common.Helper;
using GroupMap.Models;
using GroupMap.Models.ViewModels;

namespace GroupMap.Service
{
    public static class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Reset();
            Mapper.Initialize(config =>
            {
                // Mapping Document
                config.CreateMap<UserProfile, ProfileViewModel>()
                    .ForMember(dest => dest.Email, c => c.MapFrom(source => source.Email))
                    .ForMember(dest => dest.FullName, c => c.MapFrom(source => source.FullName))
                    .ForMember(dest => dest.PhoneNum, c => c.MapFrom(source => source.PhoneNum))
                    .ForMember(dest => dest.RegisterDate, c => c.MapFrom(source => Utility.GetUtcTimeFromTimeStamp(source.RegisterDate)));
            });
        }
    }
}