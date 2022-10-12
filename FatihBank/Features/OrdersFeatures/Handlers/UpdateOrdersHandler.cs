using AutoMapper;
using FatihBank.DTOs;
using FatihBank.Features.OrdersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Handlers
{
    public class UpdateOrdersHandler : IRequestHandler<UpdateOrdersCommand, Unit>
    {
        private readonly IOrdersRepository ordersRepository;
        private readonly IMapper mapper;

        public UpdateOrdersHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            this.ordersRepository = ordersRepository;
            this.mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateOrdersCommand request, CancellationToken cancellationToken)
        {
            var ordersDto = mapper.Map<OrdersDto>(request);
            await ordersRepository.Update(request.Id, ordersDto);
            return Unit.Value;
        }
    }
}