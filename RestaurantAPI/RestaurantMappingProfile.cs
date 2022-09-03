﻿using AutoMapper;
using RestaurantAPI.Dto;
using RestaurantAPI.Entities;

namespace RestaurantAPI
{
    public class RestaurantMappingProfile : Profile
    {
        public RestaurantMappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>()
                .ForMember(m => m.City, c => c.MapFrom(s => s.Adress.City))
                .ForMember(m => m.Street, c => c.MapFrom(s => s.Adress.Street))
                .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.Adress.PostalCode));

            CreateMap<Dish, DishDto>();

            CreateMap<CreateRestaurantDto, Restaurant>()
                .ForMember(r => r.Adress, 
                    c => c.MapFrom(dto => new Adress() 
                    { City = dto.City, PostalCode = dto.PostalCode, Street = dto.Street }));

            CreateMap<CreateDishDto, Dish>();
        }
    }
}
