using FatihBank.Features.AvgFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Handlers
{
    public class DeleteAvgHandler : IRequestHandler<DeleteAvgCommand, Unit>
    {
        private readonly IAvgRepository avgRepository;

        public DeleteAvgHandler(IAvgRepository avgRepository)
        {
            this.avgRepository = avgRepository;
        }

        public async Task<Unit> Handle(DeleteAvgCommand request, CancellationToken cancellationToken)
        {
            await avgRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
