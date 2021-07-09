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
    public class AddPhoneBookCommandEventHandler : IMessageRequestHandler<AddPhoneBookCommand, PhoneBookResponse>
    {
        private readonly IPhoneBookRepository _phonebookRepository;
        private readonly IMapper _mapper;

        public AddPhoneBookCommandEventHandler(IPhoneBookRepository phonebookRepository, IMapper mapper)
        {
            _phonebookRepository = phonebookRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<PhoneBookResponse>> Handle(AddPhoneBookCommand request, CancellationToken cancellationToken)
        {
            var phonebook = _mapper.Map<PhoneBook>(request.CommandData);
            phonebook.PhoneBookId = Guid.NewGuid();
            _phonebookRepository.Add(phonebook);
            await _phonebookRepository.Save();

            return new CommandResult<PhoneBookResponse>(_mapper.Map<PhoneBookResponse>(phonebook), Guid.NewGuid(), true, string.Empty);
        }
    }
}
