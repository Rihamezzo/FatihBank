using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.OrdersFeatures.Commands;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Handlers
{
    public class AddOrdersHandler : IRequestHandler<AddOrdersCommand, MSS_DEF_Orders>
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IMapper mapper;

        public AddOrdersHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            this.ordersRepository = ordersRepository;
            this.mapper = mapper;
        }

        public async Task<MSS_DEF_Orders> Handle(AddOrdersCommand request, CancellationToken cancellationToken)
        {
            var ordersDto = mapper.Map<OrdersDto>(request);
            return await ordersRepository.Add(ordersDto);
        }
    }
}
