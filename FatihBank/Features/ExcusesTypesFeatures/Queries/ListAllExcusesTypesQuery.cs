using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ExcusesTypesFeatures.Queries
{
    public class ListAllExcusesTypesQuery : IRequest<PaginationResponse<MSS_ATT_ExcusesTypes>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllExcusesTypesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}