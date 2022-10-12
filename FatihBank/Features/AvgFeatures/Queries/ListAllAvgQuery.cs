using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.AvgFeatures.Queries
{
    public class ListAllAvgQuery : IRequest<PaginationResponse<MSS_FIN_Avg>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllAvgQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}