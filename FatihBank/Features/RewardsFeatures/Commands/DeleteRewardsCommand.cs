using MediatR;

namespace FatihBank.Features.RewardsFeatures.Commands
{
    public class DeleteRewardsCommand : IRequest
    {
        public int Id { get; set; }
    }
}