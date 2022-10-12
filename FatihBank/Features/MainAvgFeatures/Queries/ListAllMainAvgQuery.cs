using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MainAvgFeatures.Queries
{
    public class ListAllMainAvgQuery : IRequest<PaginationResponse<MSS_AVG_MainAvg>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllMainAvgQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}
