using FatihBank.Features.StoresFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Handlers
{
    public class DeleteStoresHandler : IRequestHandler<DeleteStoresCommand, Unit>
    {
        private readonly IStoresRepository storesRepository;

        public DeleteStoresHandler(IStoresRepository storesRepository)
        {
            this.storesRepository = storesRepository;
        }

        public async Task<Unit> Handle(DeleteStoresCommand request, CancellationToken cancellationToken)
        {
            await storesRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}