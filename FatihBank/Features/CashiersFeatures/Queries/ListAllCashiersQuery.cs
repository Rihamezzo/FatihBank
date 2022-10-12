using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CashiersFeatures.Queries
{
    public class ListAllCashiersQuery : IRequest<PaginationResponse<MSS_DEF_Cashiers>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllCashiersQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}