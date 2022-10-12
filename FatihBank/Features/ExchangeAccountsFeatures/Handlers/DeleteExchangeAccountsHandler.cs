using FatihBank.Features.ExchangeAccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ExchangeAccountsFeatures.Handlers
{
    public class DeleteExchangeAccountsHandler : IRequestHandler<DeleteExchangeAccountsCommand, Unit>
    {
        private readonly IExchangeAccountsRepository exchangeAccountsRepository;

        public DeleteExchangeAccountsHandler(IExchangeAccountsRepository exchangeAccountsRepository)
        {
            this.exchangeAccountsRepository = exchangeAccountsRepository;
        }

        public async Task<Unit> Handle(DeleteExchangeAccountsCommand request, CancellationToken cancellationToken)
        {
            await exchangeAccountsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}