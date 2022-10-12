using FatihBank.Features.P_PricesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Handlers
{
    public class DeleteP_PricesHandler : IRequestHandler<DeleteP_PricesCommand, Unit>
    {
        private readonly IP_PricesRepository p_PricesRepository;

        public DeleteP_PricesHandler(IP_PricesRepository p_PricesRepository)
        {
            this.p_PricesRepository = p_PricesRepository;
        }

        public async Task<Unit> Handle(DeleteP_PricesCommand request, CancellationToken cancellationToken)
        {
            await p_PricesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
