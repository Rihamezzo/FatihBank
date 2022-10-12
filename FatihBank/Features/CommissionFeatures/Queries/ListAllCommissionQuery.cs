using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CommissionFeatures.Queries
{
    public class ListAllCommissionQuery : IRequest<PaginationResponse<MSS_DEF_Commission>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllCommissionQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
