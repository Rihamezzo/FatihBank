using FatihBank.Features.AccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AccountsFeatures.Handlers
{
    public class DeleteAccountsHandler : IRequestHandler<DeleteAccountsCommand, Unit>
    {
        private readonly IAccountsRepository accountsRepository;

        public DeleteAccountsHandler(IAccountsRepository accountsRepository)
        {
            this.accountsRepository = accountsRepository;
        }

        public async Task<Unit> Handle(DeleteAccountsCommand request, CancellationToken cancellationToken)
        {
            await accountsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
