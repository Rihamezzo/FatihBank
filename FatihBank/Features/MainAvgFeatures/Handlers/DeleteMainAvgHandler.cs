using FatihBank.Features.MainAvgFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Handlers
{
    public class DeleteMainAvgHandler : IRequestHandler<DeleteMainAvgCommand, Unit>
    {
        private readonly IMainAvgRepository mainAvgRepository;

        public DeleteMainAvgHandler(IMainAvgRepository mainAvgRepository)
        {
            this.mainAvgRepository = mainAvgRepository;
        }

        public async Task<Unit> Handle(DeleteMainAvgCommand request, CancellationToken cancellationToken)
        {
            await mainAvgRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
