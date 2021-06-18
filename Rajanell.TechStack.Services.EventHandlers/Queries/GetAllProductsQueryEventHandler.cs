using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Query.Product;
using Rajanell.TechStack.Application.Events.Query.ProductCategory;
using Rajanell.TechStack.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Queries
{
    public class GetAllProductsQueryEventHandler : IMessageRequestHandler<GetAllProductQuery, List<ProductResponse>>
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryEventHandler(IGenericRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<List<ProductResponse>>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var searchString = request.QueryData.Search;
            if(!string.IsNullOrEmpty(searchString))
            {
                var isGuid = Guid.TryParse(searchString, out Guid searchGuid);
                var searchedProducts = isGuid ? await _productRepository.Find(x => x.ProductCategoryId == searchGuid || x.ProductId == searchGuid) :
                    await _productRepository.Find(x => x.Name.Contains(searchString));
                return new CommandResult<List<ProductResponse>>(_mapper.Map<List<ProductResponse>>(searchedProducts), Guid.NewGuid(), true, string.Empty);
            }

            var products = await _productRepository.GetAll();
            return new CommandResult<List<ProductResponse>>(_mapper.Map<List<ProductResponse>>(products), Guid.NewGuid(), true, string.Empty);
        }
    }
}
