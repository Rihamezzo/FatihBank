using FatihBank.Features.PricesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.PricesFeatures.Handlers
{
    public class DeletePricesHandler : IRequestHandler<DeletePricesCommand, Unit>
    {
        private readonly IPricesRepository pricesRepository;

        public DeletePricesHandler(IPricesRepository pricesRepository)
        {
            this.pricesRepository = pricesRepository;
        }

        public async Task<Unit> Handle(DeletePricesCommand request, CancellationToken cancellationToken)
        {
            await pricesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}