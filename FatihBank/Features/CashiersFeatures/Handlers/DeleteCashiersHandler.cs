using FatihBank.Features.MSS_DEF_CashiersFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Handlers
{
    public class DeleteCashiersHandler : IRequestHandler<DeleteCashiersCommand, Unit>
    {
        private readonly ICashiersRepository cashiersRepository;

        public DeleteCashiersHandler(ICashiersRepository cashiersRepository)
        {
            this.cashiersRepository = cashiersRepository;
        }

        public async Task<Unit> Handle(DeleteCashiersCommand request, CancellationToken cancellationToken)
        {
            await cashiersRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
