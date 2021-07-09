using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Phonebook.Application.Events;
using Rajanell.TechStack.Phonebook.Core.Model;
using Rajanell.TechStack.Phonebook.Core.Model.ResponseDTO;
using Rajanell.TechStack.Phonebook.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Phonebook.Services.EventHandlers
{
    public class AddPhoneBookEntryEventHandler : IMessageRequestHandler<AddPhoneBookEntryCommand, PhoneBookEntryResponse>
    {
        private readonly IPhoneBookEntryRepository _phonebookEntryRepository;
        private readonly IMapper _mapper;

        public AddPhoneBookEntryEventHandler(IPhoneBookEntryRepository phonebookRepository, IMapper mapper)
        {
            _phonebookEntryRepository = phonebookRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<PhoneBookEntryResponse>> Handle(AddPhoneBookEntryCommand request, CancellationToken cancellationToken)
        {
            var phonebookEntry = _mapper.Map<Entry>(request.CommandData);
            phonebookEntry.EntryId = Guid.NewGuid();
            _phonebookEntryRepository.Add(phonebookEntry);
            await _phonebookEntryRepository.Save();

            return new CommandResult<PhoneBookEntryResponse>(_mapper.Map<PhoneBookEntryResponse>(phonebookEntry), Guid.NewGuid(), true, string.Empty);
        }
    }
}
