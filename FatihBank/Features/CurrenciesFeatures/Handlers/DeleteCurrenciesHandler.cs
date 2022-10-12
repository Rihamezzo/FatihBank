using FatihBank.Features.MSS_DEF_CurrenciesFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CurrenciesFeatures.Handlers
{
    public class DeleteCurrenciesHandler : IRequestHandler<DeleteCurrenciesCommand,Unit>
    {
        private readonly ICurrenciesRepository currenciesRepository;

        public DeleteCurrenciesHandler(ICurrenciesRepository currenciesRepository)
        {
            this.currenciesRepository = currenciesRepository;
        }

        public async Task<Unit> Handle(DeleteCurrenciesCommand request, CancellationToken cancellationToken)
        {
            await currenciesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
