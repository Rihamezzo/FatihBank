using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.StoresFeatures.Queries
{
    public class ListAllStoresQuery : IRequest<PaginationResponse<MSS_DEF_Stores>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllStoresQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}