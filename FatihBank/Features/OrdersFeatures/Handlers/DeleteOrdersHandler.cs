using FatihBank.Features.OrdersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Handlers
{
    public class DeleteOrdersHandler : IRequestHandler<DeleteOrdersCommand, Unit>
    {
        private readonly IOrdersRepository ordersRepository;

        public DeleteOrdersHandler(IOrdersRepository ordersRepository)
        {
            this.ordersRepository = ordersRepository;
        }

        public async Task<Unit> Handle(DeleteOrdersCommand request, CancellationToken cancellationToken)
        {
            await ordersRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
