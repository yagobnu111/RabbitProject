using AutoMapper;
using Model;
using Service.Model.User;
using System;

namespace Service.Mappers
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserModelInsert, User>()
                .ForMember(dest => dest.Active, opt => opt.MapFrom(src => true))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => DateTime.Now));
            CreateMap<UserModelUpdate, User>()
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => DateTime.Now));

            //.ForMember(dest => dest.Vehicle, opt => opt.MapFrom(src => Enum.GetName(typeof(VehicleTypes), src.VehicleType))).ReverseMap(); 
            // how to show enum name
        }
    }
}
