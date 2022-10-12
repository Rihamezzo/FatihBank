using FatihBank.DTOs;
using FatihBank.Models;
using MediatR;

namespace FatihBank.Features.MonthlyListFeatures.Queries
{
    public class ListAllMonthlyListQuery : IRequest<PaginationResponse<MSS_CUS_Add_To_Monthly_List>>
    {
        public int page { get; set; }
        public int pageSize { get; set; }

        public ListAllMonthlyListQuery(int page, int pageSize)
        {
            this.page = page;
            this.pageSize = pageSize;
        }
    }
}