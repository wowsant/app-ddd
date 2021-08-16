using APP.Domain.Entities;
using APP.Domain.Model;
using AutoMapper;

namespace APP.CrossCutting.Mappings
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<UserModel, UserEntity>()
               .ReverseMap();
        }
    }
}
