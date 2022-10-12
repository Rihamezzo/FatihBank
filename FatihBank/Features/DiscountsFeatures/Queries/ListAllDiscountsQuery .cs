using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.DiscountsFeatures.Queries
{
    public class ListAllDiscountsQuery : IRequest<PaginationResponse<MSS_ATT_Discounts>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllDiscountsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}