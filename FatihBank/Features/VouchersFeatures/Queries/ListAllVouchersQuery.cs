
using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.VouchersFeatures.Queries
{
    public class ListAllVouchersQuery : IRequest<PaginationResponse<MSS_DEF_Vouchers>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllVouchersQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}