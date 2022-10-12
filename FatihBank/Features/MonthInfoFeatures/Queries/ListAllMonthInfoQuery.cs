using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MonthInfoFeatures.Queries
{
    public class ListAllMonthInfoQuery : IRequest<PaginationResponse<MSS_ATT_Month_Info>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllMonthInfoQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}