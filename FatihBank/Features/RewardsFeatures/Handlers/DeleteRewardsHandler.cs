using FatihBank.Features.RewardsFeatures.Commands;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RewardsFeatures.Handlers
{
    public class DeleteRewardsHandler : IRequestHandler<DeleteRewardsCommand, Unit>
    {
        private readonly IRewardsRepository rewardsRepository;

        public DeleteRewardsHandler(IRewardsRepository rewardsRepository)
        {
            this.rewardsRepository = rewardsRepository;
        }

        public async Task<Unit> Handle(DeleteRewardsCommand request, CancellationToken cancellationToken)
        {
            await rewardsRepository.Delete(request.Id);
            return Unit.Value;
        }
    }
}