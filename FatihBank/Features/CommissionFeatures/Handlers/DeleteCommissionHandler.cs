using FatihBank.Features.MSS_DEF_CommissionFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Handlers
{
    public class DeleteCommissionHandler : IRequestHandler<DeleteCommissionCommand, Unit>
    {
        private readonly ICommissionRepository commissionRepository;

        public DeleteCommissionHandler(ICommissionRepository commissionRepository)
        {
            this.commissionRepository = commissionRepository;
        }

        public async Task<Unit> Handle(DeleteCommissionCommand request, CancellationToken cancellationToken)
        {
            await commissionRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}
