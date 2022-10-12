using FatihBank.Features.MSS_DEF_AVGsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Handlers
{
    public class DeleteAVGsHandler : IRequestHandler <DeleteAVGsCommand,Unit>
    {
        private readonly IAVGsRepository aVGsRepository;

        public DeleteAVGsHandler(IAVGsRepository aVGsRepository)
        {
            this.aVGsRepository = aVGsRepository;
        }

        public async Task<Unit> Handle(DeleteAVGsCommand request, CancellationToken cancellationToken)
        {
            await aVGsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
