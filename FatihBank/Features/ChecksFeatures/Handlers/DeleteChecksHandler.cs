using FatihBank.Features.ChecksFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.ChecksFeatures.Handlers
{
    public class DeleteChecksHandler : IRequestHandler<DeleteChecksCommand,Unit>
    {
        private readonly IChecksRepository checksRepository;

        public DeleteChecksHandler(IChecksRepository checksRepository)
        {
            this.checksRepository = checksRepository;
        }

        public async Task<Unit> Handle(DeleteChecksCommand request, CancellationToken cancellationToken)
        {
            await checksRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
