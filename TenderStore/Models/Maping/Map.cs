using AutoMapper;
using TS.Domain.Core.Dtos;
using TS.Endpoints.UI.Models.ViewModel;

namespace TS.Endpoints.UI.Models.Maping
{
    public class Map : Profile
    {
        public Map()
        {
            CreateMap<UserDto, RegisterViewModel>().ReverseMap();
        }
    }
}
