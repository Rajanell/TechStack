﻿using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStach.Core.Model.ResponseDTO;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.ProductCategory;
using Rajanell.TechStack.Core.Repository.Write;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Commands
{
    public class UpdateProductCategoryCommandEventHandler : IMessageRequestHandler<UpdateProductCategoryCommand, ProductCategoryResponse>
    {
        private readonly IProductCategoryCommandRepository _productCategoryCommandRepository;
        private readonly IMapper _mapper;

        public UpdateProductCategoryCommandEventHandler(IProductCategoryCommandRepository productCategoryCommandRepository, IMapper mapper)
        {
            _productCategoryCommandRepository = productCategoryCommandRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<ProductCategoryResponse>> Handle(UpdateProductCategoryCommand request, CancellationToken cancellationToken)
        {
            var productCategory = _mapper.Map<ProductCategory>(request.CommandData);
            _productCategoryCommandRepository.Update(productCategory);
            await _productCategoryCommandRepository.Save();

            return new CommandResult<ProductCategoryResponse>(_mapper.Map<ProductCategoryResponse>(productCategory), productCategory.ProductCategoryId, true, string.Empty);
        }
    }
}
