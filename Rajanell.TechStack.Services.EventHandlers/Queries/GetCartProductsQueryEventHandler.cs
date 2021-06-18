using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Query.Product;
using Rajanell.TechStack.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Queries
{
    public class GetCartProductsQueryEventHandler : IMessageRequestHandler<GetCartProductsQuery, List<ProductResponse>>
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IMapper _mapper;

        public GetCartProductsQueryEventHandler(IGenericRepository<Product> productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<CommandResult<List<ProductResponse>>> Handle(GetCartProductsQuery request, CancellationToken cancellationToken)
        {
            List<Guid> cartItems = request.QueryData.Split(';').ToList().Select(s=> Guid.Parse(s)).ToList();
            var products = await _productRepository.Find(x => cartItems.Contains(x.ProductId));
            return new CommandResult<List<ProductResponse>>(_mapper.Map<List<ProductResponse>>(products), Guid.NewGuid(), true, string.Empty);
        }
    }
}
