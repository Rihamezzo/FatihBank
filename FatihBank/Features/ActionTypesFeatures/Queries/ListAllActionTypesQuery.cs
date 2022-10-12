using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ActionTypesFeatures.Queries
{
    public class ListAllActionTypesQuery : IRequest<PaginationResponse<MSS_INF_Action_Types>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllActionTypesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}