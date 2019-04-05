﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidly.DTOs;
using Vidly.Models;

namespace Vidly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>(); 
            Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType,MembershipTypeDto>();
            Mapper.CreateMap<Genre,GenreDto>();
            Mapper.CreateMap<Rental, NewRentalDto>();
            Mapper.CreateMap<MovieDto,Movie>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());
            Mapper.CreateMap<NewRentalDto, Rental>();
            //Mapper.CreateMap<MembershipTypeDto, MembershipType>().ForMember(c => c.Id, opt => opt.Ignore());
           
        }
    }
}