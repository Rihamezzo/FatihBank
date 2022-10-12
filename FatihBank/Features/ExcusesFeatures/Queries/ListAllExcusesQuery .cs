using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ExcusesFeatures.Queries
{
    public class ListAllExcusesQuery : IRequest<PaginationResponse<MSS_ATT_Excuses>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllExcusesQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}