using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.OrdersFeatures.Queries
{
    public class ListAllOrdersQuery : IRequest<PaginationResponse<MSS_DEF_Orders>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllOrdersQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}