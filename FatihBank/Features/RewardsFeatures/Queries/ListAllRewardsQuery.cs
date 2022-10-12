using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.RewardsFeatures.Queries
{
    public class ListAllRewardsQuery : IRequest<PaginationResponse<MSS_ATT_Rewards>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllRewardsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}