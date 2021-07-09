using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Application.Events;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using Rajanell.TechStack.Phonebook.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Services.EventHandlers
{
    public class FindPhoneBookEntryQueryEventHandler : IMessageRequestHandler<FindPhoneBookEntryQuery, List<PhoneBookEntryResponse>>
    {
        private readonly IPhoneBookEntryRepository _phonebookEntryRepository;
        private readonly IMapper _mapper;

        public FindPhoneBookEntryQueryEventHandler(IPhoneBookEntryRepository phonebookEntryRepository, IMapper mapper)
        {
            _phonebookEntryRepository = phonebookEntryRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<List<PhoneBookEntryResponse>>> Handle(FindPhoneBookEntryQuery request, CancellationToken cancellationToken)
        { 
                var searchString = request.QueryData;
                var entries = await _phonebookEntryRepository.Find(x => x.Name.Contains(searchString) || x.PhoneNumber.Contains(searchString));
                return new CommandResult<List<PhoneBookEntryResponse>>(_mapper.Map<List<PhoneBookEntryResponse>>(entries), Guid.NewGuid(), true, string.Empty);            
        }
    }
}
