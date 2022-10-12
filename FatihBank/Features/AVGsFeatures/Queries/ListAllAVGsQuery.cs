using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_AVGsFeatures.Queries
{
    public class ListAllAVGsQuery : IRequest<PaginationResponse<MSS_DEF_AVGs>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllAVGsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}