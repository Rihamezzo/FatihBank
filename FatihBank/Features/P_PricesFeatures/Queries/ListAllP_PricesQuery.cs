using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.P_PricesFeatures.Queries
{
    public class ListAllP_PricesQuery : IRequest<PaginationResponse<MSS_DEF_P_Prices>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllP_PricesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}