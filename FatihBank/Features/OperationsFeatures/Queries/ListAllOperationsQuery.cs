using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.OperationsFeatures.Queries
{
    public class ListAllOperationsQuery : IRequest<PaginationResponse<MSS_CAS_Operations>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllOperationsQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}