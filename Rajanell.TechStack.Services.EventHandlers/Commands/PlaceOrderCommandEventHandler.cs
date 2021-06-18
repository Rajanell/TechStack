using AutoMapper;
using Rajanell.TechStach.Core.Model;
using Rajanell.TechStack.Application.Communication;
using Rajanell.TechStack.Application.Events.Command.Order;
using Rajanell.TechStack.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rajanell.TechStack.Services.EventHandlers.Commands
{
    public class PlaceOrderCommandEventHandler : IMessageRequestHandler<PlaceOrderCommand, Guid>
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        private readonly IGenericRepository<OrderDetail> _orderDetailRepository;
        private readonly IMapper _mapper;

        public PlaceOrderCommandEventHandler(IGenericRepository<Product> productRepository, IGenericRepository<Order> orderRepository, IGenericRepository<OrderDetail> orderDetailRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _orderRepository = orderRepository;
            _orderDetailRepository = orderDetailRepository;
            _mapper = mapper;
        }

        public async Task<CommandResult<Guid>> Handle(PlaceOrderCommand request, CancellationToken cancellationToken)
        {
            List<Guid> cartItems = request.CommandData.CartItems;
            var products = await _productRepository.Find(x => cartItems.Contains(x.ProductId));

            var order = new Order { OrderId = Guid.NewGuid(), Date = DateTime.Now, UserId = Guid.Parse(request.CommandData.UserId) };
            _orderRepository.Add(order);
            foreach(var product in products)
            {
                var count = cartItems.Where(x => x == product.ProductId).Count();
                _orderDetailRepository.Add(new OrderDetail
                {
                    OrderDetailId = Guid.NewGuid(),
                    OrderId = order.OrderId,
                    Price = product.Price,
                    ProductId = product.ProductId,
                    Quantiry = count,
                    TotalPrice = count * product.Price,
                    ProductName = product.Name,
                    ProductImage = product.Image

                });
            }
            await _orderRepository.Save();
            await _orderDetailRepository.Save();

            return new CommandResult<Guid>(order.OrderId, Guid.NewGuid(), true, string.Empty);
        }
    }
}
