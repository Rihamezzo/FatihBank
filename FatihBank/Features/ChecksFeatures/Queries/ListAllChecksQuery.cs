using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ChecksFeatures.Queries
{
    public class ListAllChecksQuery : IRequest<PaginationResponse<MSS_ACC_Checks>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllChecksQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
