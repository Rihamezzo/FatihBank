using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.GroupsFeatures.Queries
{
    public class ListAllGroupsQuery : IRequest<PaginationResponse<MSS_DEF_Groups>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllGroupsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}