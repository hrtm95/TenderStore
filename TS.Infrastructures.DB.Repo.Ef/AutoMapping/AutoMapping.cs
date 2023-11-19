using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS.Domain.Core.Dtos;
using TS.Domain.Core.Entities;

namespace TS.Infrastructures.DB.Repo.Ef.AutoMapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AddressDto, Address>().ReverseMap();
            CreateMap<AuctionInformationDto, AuctionInformation>().ReverseMap();
            CreateMap<AuctionPriceDto, AuctionPrice>().ReverseMap();
            CreateMap<ShopStandDto, ShopStand>().ReverseMap();
            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CommentDto, Comment>().ReverseMap();
            CreateMap<CustomAttributeDto, CustomAttribute>().ReverseMap();
            CreateMap<FixedPriceDto, FixedPrice>().ReverseMap();
            CreateMap<MedalDto, Medal>().ReverseMap();
            CreateMap<OrderLineDto, OrderLine>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();

        }
    }
}
