using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ModulesFeatures.Queries
{
    public class ListAllModulesQuery : IRequest<PaginationResponse<MSS_DEF_Modules>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllModulesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}