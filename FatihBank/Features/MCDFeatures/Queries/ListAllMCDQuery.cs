using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MCDFeatures.Queries
{
    public class ListAllMCDQuery : IRequest<PaginationResponse<MSS_DEF_MCD>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllMCDQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}