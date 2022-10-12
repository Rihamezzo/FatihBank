using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MSS_DEF_UsersFeatures.Queries
{
    public class ListAllUsersQuery : IRequest<PaginationResponse<MSS_DEF_Users>?>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllUsersQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
