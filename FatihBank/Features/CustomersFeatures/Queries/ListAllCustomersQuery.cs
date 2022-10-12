using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_CustomersFeatures.Queries
{
    public class ListAllCustomersQuery : IRequest<PaginationResponse<MSS_DEF_Customers>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllCustomersQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
