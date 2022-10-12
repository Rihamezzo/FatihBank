using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.PermissionsFeatures.Queries
{
    public class ListAllPermissionsQuery : IRequest<PaginationResponse<MSS_DEF_Permissions>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllPermissionsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}