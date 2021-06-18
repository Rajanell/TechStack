using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.RequestDTO;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Services.EventHandlers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserResponse>().ReverseMap();
            CreateMap<User, UserRequest>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryRequest>().ReverseMap();
            CreateMap<ProductCategory, ProductCategoryResponse>().ReverseMap();
            CreateMap<Product, ProductResponse>().ReverseMap();
        }
    }
}
