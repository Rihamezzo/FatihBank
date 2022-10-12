using FatihBank.DTOs;
using FatihBank.Features.RewardsFeatures.Queries;
using FatihBank.Models;
using FatihBank.Repositories;
using MediatR;

namespace FatihBank.Features.RewardsFeatures.Handlers
{
    public class ListAllRewardsHandler : IRequestHandler<ListAllRewardsQuery, PaginationResponse<MSS_ATT_Rewards>>
    {
        private readonly IRewardsRepository rewardsRepository;

        public ListAllRewardsHandler(IRewardsRepository rewardsRepository)
        {
            this.rewardsRepository = rewardsRepository;
        }

        public async Task<PaginationResponse<MSS_ATT_Rewards>> Handle(ListAllRewardsQuery request, CancellationToken cancellationToken)
        {
            return await rewardsRepository.ListAll(request.page, request.pageSize);
        }
    }
}
