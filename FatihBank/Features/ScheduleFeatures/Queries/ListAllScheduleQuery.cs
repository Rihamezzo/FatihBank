using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.ScheduleFeatures.Queries
{
    public class ListAllScheduleQuery : IRequest<PaginationResponse<MSS_DEF_Schedule>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllScheduleQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}