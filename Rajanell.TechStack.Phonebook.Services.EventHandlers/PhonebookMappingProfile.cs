using AutoMapper;
using Rajanell.TechStack.Phonebook.Core.Model;
using Rajanell.TechStack.Phonebook.Core.Model.RequestDTO;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Rajanell.TechStack.Phonebook.Services.EventHandlers
{
    public class PhonebookMappingProfile : Profile
    {
        public PhonebookMappingProfile()
        {
            CreateMap<PhoneBook, PhoneBookResponse>().ReverseMap();
            CreateMap<PhoneBook, PhoneBookRequest>().ReverseMap();
            CreateMap<Entry, PhoneBookEntryRequest>().ReverseMap();
            CreateMap<Entry, PhoneBookEntryResponse>().ReverseMap();
        }
    }
}
