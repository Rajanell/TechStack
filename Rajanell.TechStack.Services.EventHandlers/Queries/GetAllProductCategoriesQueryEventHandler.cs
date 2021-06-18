using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Query.ProductCategory;
using Rajanell.TechStack.Core.Repository.Read;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Queries
{
    public class GetAllProductCategoriesQueryEventHandler : IMessageRequestHandler<GetAllProductCategoriesQuery, List<ProductCategoryResponse>>
    {
        private readonly IProductCategoryQueryRepository _productCategoryQueryRepository;
        private readonly IMapper _mapper;

        public GetAllProductCategoriesQueryEventHandler(IProductCategoryQueryRepository productCategoryQueryRepository, IMapper mapper)
        {
            _productCategoryQueryRepository = productCategoryQueryRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<List<ProductCategoryResponse>>> Handle(GetAllProductCategoriesQuery request, CancellationToken cancellationToken)
        {
            var categories = await _productCategoryQueryRepository.GetAll();
            return new CommandResult<List<ProductCategoryResponse>>(_mapper.Map<List<ProductCategoryResponse>>(categories), Guid.NewGuid(), true, string.Empty);
        }
    }
}
