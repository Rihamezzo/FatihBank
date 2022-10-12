
using FatihBank.Features.FavAccountsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.FavAccountsFeatures.Handlers
{
    public class DeleteFavAccountsHandler : IRequestHandler<DeleteFavAccountsCommand, Unit>
    {
        private readonly IFavAccountsRepository favAccountsRepository;

        public DeleteFavAccountsHandler(IFavAccountsRepository favAccountsRepository)
        {
            this.favAccountsRepository = favAccountsRepository;
        }

        public async Task<Unit> Handle(DeleteFavAccountsCommand request, CancellationToken cancellationToken)
        {
            await favAccountsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}