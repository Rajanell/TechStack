using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Application.Events;
using Rajanell.TechStack.Phonebook.Core.Model;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using Rajanell.TechStack.Phonebook.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Services.EventHandlers
{
    public class FindPhonebookQueryEventHandler : IMessageRequestHandler<FindPhoneBookQuery, List<PhoneBookResponse>>
    {
        private readonly IPhoneBookRepository _phonebookRepository;
        private readonly IPhoneBookEntryRepository _phonebookEntryRepository;
        private readonly IMapper _mapper;

        public FindPhonebookQueryEventHandler(IPhoneBookRepository phonebookRepository, IMapper mapper, IPhoneBookEntryRepository phonebookEntryRepository)
        {
            _phonebookRepository = phonebookRepository;
            _mapper = mapper;
            _phonebookEntryRepository = phonebookEntryRepository;
    }

        public async Task<CommandResult<List<PhoneBookResponse>>> Handle(FindPhoneBookQuery request, CancellationToken cancellationToken)
        {
            if(request.QueryData.PhoneBookId != Guid.Empty && string.IsNullOrEmpty(request.QueryData.SearchString))
            {
                var phoneBook = await _phonebookRepository.GetByID(request.QueryData.PhoneBookId);
                return new CommandResult<List<PhoneBookResponse>>(_mapper.Map<List<PhoneBookResponse>>( new List<PhoneBook> { phoneBook }), Guid.NewGuid(), true, string.Empty);
            }
            if (request.QueryData.PhoneBookId == Guid.Empty && !string.IsNullOrEmpty(request.QueryData.SearchString))
            {
                var searchString = request.QueryData.SearchString;
                var phoneBookSearch = await _phonebookRepository.Find(x=>x.Name.Contains(searchString));
                return new CommandResult<List<PhoneBookResponse>>(_mapper.Map<List<PhoneBookResponse>>(phoneBookSearch), Guid.NewGuid(), true, string.Empty);
            }
            var phoneBooks = await _phonebookRepository.GetAll();
            return new CommandResult<List<PhoneBookResponse>>(_mapper.Map<List<PhoneBookResponse>>(phoneBooks), Guid.NewGuid(), true, string.Empty);
        }
    }
}
