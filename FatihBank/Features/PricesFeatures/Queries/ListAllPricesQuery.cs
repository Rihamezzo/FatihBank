using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.PricesFeatures.Queries
{
    public class ListAllPricesQuery : IRequest<PaginationResponse<MSS_DEF_Prices>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllPricesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}